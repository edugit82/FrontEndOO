namespace FrontEndOO.FrontEnd.Containers
{
    public partial class Container
    {
        public string ContainerBaseExemplo()
        {
            string container = this.ContainerBase("#corpo_principal", "container_exemplo");
            container += Environment.NewLine;

            container += OpenFile.Open(@"\wwwroot\js\objetos\containers\container_exemplo.js");
            container = container.Replace("$$[id]$$", "#container_exemplo");
            container += Environment.NewLine;

            return container;
        }
    }
}
