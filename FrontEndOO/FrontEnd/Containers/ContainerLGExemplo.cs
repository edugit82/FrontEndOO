namespace FrontEndOO.FrontEnd.Containers
{
    public partial class Container
    {
        public string ContainerLGExemplo()
        {
            string container = this.ContainerLG("#corpo_principal", "containerlg_exemplo");
            container += Environment.NewLine;

            container += OpenFile.Open(@"\wwwroot\js\objetos\containers\containerlg_exemplo.js");
            container = container.Replace("$$[id]$$", "#containerlg_exemplo");
            container += Environment.NewLine;

            return container;
        }
    }
}
