namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoPrimary
    {
        public string BotaoPrimary(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-primary");
        }
    }

    public interface IBotaoPrimary
    {
        public string BotaoPrimary(string parent, string id);
    }
}
