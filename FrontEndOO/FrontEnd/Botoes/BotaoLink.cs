namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoLink
    {
        public string BotaoLink(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-link");
        }
    }
    public interface IBotaoLink
    {
        public string BotaoLink(string parent, string id);
    }
}
