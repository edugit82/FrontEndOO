namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoBootStrap
    {
        public string BotaoBootStrap(string parent, string id, string _class)
        {
            string botao = this.BotaoJs(parent, id);
            botao += Environment.NewLine;            

            string botaoprimary = OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_bootstrap.js");
            botaoprimary = botaoprimary.Replace("$$[buttonselector]$$", "#" + id);
            botaoprimary = botaoprimary.Replace("$$[class]$$", _class);
            string bt = (botao + botaoprimary);           

            return bt;
        }
    }
    public interface IBotaoBootStrap
    {
        public string BotaoBootStrap(string parent, string id, string _class);
    }
}

