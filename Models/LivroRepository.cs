using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Web;
using Projeto_Biblioteca.Models;

namespace Projeto_Biblioteca.Class
{
    public class LivroRepository : ILivroRepository
    {
        private const string ArquivoLivros = "~/App_Data/livros.xml"; // Caminho  para a pasta Data
        private List<Livro> livros = new List<Livro>();

        public LivroRepository()
        {
            // Carregar livros do XML
            CarregarLivros();
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
            SalvarLivros();  // Salva os livros 
        }

        public List<Livro> ListarLivros()
        {
            return livros;
        }

        // Método para carregar os livros do arquivo XML
        private void CarregarLivros()
        {
            var caminhoCompleto = HttpContext.Current.Server.MapPath(ArquivoLivros);  

            if (File.Exists(caminhoCompleto))
            {
                var serializer = new XmlSerializer(typeof(List<Livro>));
                using (var stream = new FileStream(caminhoCompleto, FileMode.Open))
                {
                    livros = (List<Livro>)serializer.Deserialize(stream);
                }
            }
        }

        // salva os livros no arquivo XML
        private void SalvarLivros()
        {
            var caminhoCompleto = HttpContext.Current.Server.MapPath(ArquivoLivros);

            // Garante que o diretório exista, se não, cria
            var diretorio = Path.GetDirectoryName(caminhoCompleto);
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio); 
            }

            try
            {
                // Serializa os livros no arquivo XML
                var serializer = new XmlSerializer(typeof(List<Livro>));
                using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                {
                    serializer.Serialize(stream, livros);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // Tratamento para problemas de permissão
                throw new Exception("Erro de permissão ao acessar o arquivo. Verifique as permissões de acesso ao diretório.", ex);
            }
            catch (Exception ex)
            {
                // Captura qualquer outro tipo de exceção
                throw new Exception("Ocorreu um erro ao salvar o arquivo de livros.", ex);
            }
        }

        // Método para remover um livro
        public void RemoverLivro(Livro livro)
        {
            livros.Remove(livro);
            SalvarLivros();  // Salva a lista após a exclusão
        }
    }
}
