namespace FrontEndOO.FrontEnd.Containers
{
    public partial class Container
    {
        public string ContainerJs(string parent, string id)
        {
            string container = OpenFile.Open(@"\wwwroot\js\objetos\containers\container.js");

            container = container.Replace("$$[parent]$$", parent);
            container = container.Replace("$$[div]$$", this.HtmlContainer);
            container = container.Replace("$$[id]$$", id);

            return container;
        }
    }
}
