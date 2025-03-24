namespace FrontEndOO.FrontEnd.Containers
{
    public partial class Container
    {
        public string ContainerSMExemplo()
        {
            string container = this.ContainerSM("#corpo_principal", "containersm_exemplo");
            container += Environment.NewLine;

            container += OpenFile.Open(@"\wwwroot\js\objetos\containers\containersm_exemplo.js");
            container = container.Replace("$$[id]$$", "#containersm_exemplo");
            container += Environment.NewLine;

            return container;
        }
    }
}
