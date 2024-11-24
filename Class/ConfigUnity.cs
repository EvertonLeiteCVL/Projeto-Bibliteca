using Unity;
using Projeto_Biblioteca.Models;
using Projeto_Biblioteca.Class;
using Projeto_Biblioteca.Controllers;

namespace Projeto_Biblioteca.Class
{
    public static class ConfigUnity
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            // Registra o repositório de livros
            container.RegisterType<ILivroRepository, LivroRepository>();

            // Registra o controlador da biblioteca
            container.RegisterType<BibliotecaController>();

            
        }
    }
}


