using System;
using Unity; 
using Projeto_Biblioteca.Class;

namespace Projeto_Biblioteca
{
    public class Global : System.Web.HttpApplication
    {
        private static IUnityContainer container;

        protected void Application_Start(object sender, EventArgs e)
        {
            // Inicializa o Unity Container
            container = new UnityContainer();

            // Registra os tipos no Unity Container
            ConfigUnity.RegisterComponents(container);

            // Armazena o container para uso global
            Application["Container"] = container;
        }
    }
}
