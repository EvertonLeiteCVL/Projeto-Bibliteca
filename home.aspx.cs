using System;
using System.Web.UI;
using Projeto_Biblioteca.Models;
using Projeto_Biblioteca.Class;
using Unity;

namespace Projeto_Biblioteca
{
    public partial class Home : Page
    {
        private ILivroRepository _livroRepository;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Obtém o UnityContainer 
            IUnityContainer container = (IUnityContainer)Application["Container"];

            // Resolve a dependência do repositório de livros
            _livroRepository = container.Resolve<ILivroRepository>();
        }

        // botão "Adicionar Livro"
        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Coletando os dados dos campos de entrada
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int ano = Convert.ToInt32(txtAno.Text);
            string isbn = txtISBN.Text;
            int numeroDePaginas = Convert.ToInt32(txtNumeroDePaginas.Text);

            // Cria um novo objeto Livro com os dados inseridos
            Livro novoLivro = new Livro(titulo, autor, ano, isbn, numeroDePaginas);

            // Adiciona o livro ao repositório
            _livroRepository.AdicionarLivro(novoLivro);

            //Limpar os campos após adicionar o livro
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtAno.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txtNumeroDePaginas.Text = string.Empty;

            // Atualiza a lista de livros ou exiba uma mensagem de sucesso
            Response.Write("Livro adicionado com sucesso!");
        }
    }
}
