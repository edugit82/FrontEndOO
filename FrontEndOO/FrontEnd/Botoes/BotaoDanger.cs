
namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoDanger
    {
        public string BotaoDanger(string parent, string id)
        {
            return this.BotaoBootStrap(parent, id, "btn btn-danger");
        }
    }
    public interface IBotaoDanger
    {
        public string BotaoDanger(string parent, string id);
    }
}
