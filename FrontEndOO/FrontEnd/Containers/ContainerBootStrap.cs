namespace FrontEndOO.FrontEnd.Containers
{
    public partial class Container
    {
        public string ContainerBootStrap(string parent, string id, string _class)
        {
            string container = this.ContainerJs(parent, id);
            container += Environment.NewLine;

            string containerbootstrap = OpenFile.Open(@"\wwwroot\js\objetos\containers\container_bootstrap.js");
            containerbootstrap = containerbootstrap.Replace("$$[containerselector]$$", "#" + id);
            containerbootstrap = containerbootstrap.Replace("$$[class]$$", _class);
            string ct = (container + containerbootstrap);

            return ct;
        }
    }
}
