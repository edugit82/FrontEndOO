using FrontEndOO.FrontEnd.Containers;

namespace FrontEndOO.FrontEnd.Principal.Corpo
{
    public class PaginaContainers
    {
        public string MontaPagina() 
        {
            string container = new Container().ContainerBaseExemplo();
            container += Environment.NewLine;

            container += new Container().ContainerSMExemplo();
            container += Environment.NewLine;

            container += new Container().ContainerMDExemplo();
            container += Environment.NewLine;

            container += new Container().ContainerLGExemplo();
            container += Environment.NewLine;

            return container;
        }
    }
}
