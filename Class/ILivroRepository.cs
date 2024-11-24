using Projeto_Biblioteca.Models;
using System.Collections.Generic;

namespace Projeto_Biblioteca.Class
{
    public interface ILivroRepository
    {
        void AdicionarLivro(Livro livro);
        List<Livro> ListarLivros();
    }
}

