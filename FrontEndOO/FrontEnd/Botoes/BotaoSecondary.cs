namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoSecondary
    {
        public string BotaoSecondary(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-secondary");
        }
    }
    public interface IBotaoSecondary
    {
        public string BotaoSecondary(string parent, string id);
    }
}

