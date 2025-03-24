namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoInfo
    {
        public string BotaoInfo(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-info");
        }
    }
    public interface IBotaoInfo
    {
        public string BotaoInfo(string parent, string id);
    }
}
