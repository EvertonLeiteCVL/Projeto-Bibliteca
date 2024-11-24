using System;

namespace ProjetoBilioteca
{
    public class Livro
    {
        public Guid Guid { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int NumeroDePaginas { get; set; }
        public string Edicao { get; set; }
        public string Disponibilidade { get; set; }

        public Livro(string titulo, string autor, string isbn, int numeroDePaginas, string edicao)
        {
            Guid = Guid.NewGuid(); //  GUID único para cada livro
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            NumeroDePaginas = numeroDePaginas;
            Edicao = edicao;
            Disponibilidade = "Disponível"; // Padrão para novo livro
        }
    }
}
