namespace FrontEndOO.FrontEnd.Containers
{
    public partial class Container
    {
        public string ContainerMDExemplo()
        {
            string container = this.ContainerMD("#corpo_principal", "containermd_exemplo");
            container += Environment.NewLine;

            container += OpenFile.Open(@"\wwwroot\js\objetos\containers\containermd_exemplo.js");
            container = container.Replace("$$[id]$$", "#containermd_exemplo");
            container += Environment.NewLine;

            return container;
        }
    }
}
