namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoSuccess
    {
        public string BotaoSuccess(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-success");
        }
    }
    public interface IBotaoSuccess
    {
        public string BotaoSuccess(string parent, string id);
    }
}
