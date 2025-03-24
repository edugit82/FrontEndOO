namespace FrontEndOO.FrontEnd.Containers
{
    public partial class Container
    {
        public string ContainerBase(string parent, string id) 
        {
            return this.ContainerBootStrap(parent, id, "container");
        }
    }
}
