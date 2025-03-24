namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoDark
    {
        public string BotaoDark(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-dark");
        }
    }
    public interface IBotaoDark
    {
        public string BotaoDark(string parent, string id);
    }
}
