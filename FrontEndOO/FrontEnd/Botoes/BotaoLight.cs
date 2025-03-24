namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoLight
    {
        public string BotaoLight(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-light");
        }
    }
    public interface IBotaoLight
    {
        public string BotaoLight(string parent, string id);
    }
}
