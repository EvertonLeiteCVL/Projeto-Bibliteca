using System;
using System.Xml.Serialization;

namespace Projeto_Biblioteca.Models
{
    [XmlRoot("Livro")] // Define o nome do elemento XML raiz
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string ISBN { get; set; }
        public int NumeroDePaginas { get; set; }

        //criar livros
        public Livro(string titulo, string autor, int ano, string isbn, int numeroDePaginas)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            ISBN = isbn;
            NumeroDePaginas = numeroDePaginas;
        }

        // Construtor necessário para a desserialização
        public Livro() { }
    }
}
