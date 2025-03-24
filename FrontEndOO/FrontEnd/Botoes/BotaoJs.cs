namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoJs
    { 
        public string BotaoJs(string parent, string id)
        {
            string botao = OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao.js");

            botao = botao.Replace("$$[parent]$$", parent);
            botao = botao.Replace("$$[button]$$", this.HtmlBotao);
            botao = botao.Replace("$$[id]$$", id);

            return botao;
        }
    }
    public interface IBotaoJs 
    {
        public string BotaoJs(string parent, string id);
    }
}

        