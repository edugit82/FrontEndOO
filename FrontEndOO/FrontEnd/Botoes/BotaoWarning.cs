namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoWarning
    {
        public string BotaoWarning(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-warning");
        }
    }
    public interface IBotaoWarning
    {
        public string BotaoWarning(string parent, string id);
    }
}
