namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoLinkExemplo
    {
        public string BotaoLinkExemplo()
        {
            string botao = this.BotaoLink("#regiao_botoes", "botao_link");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_link_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_link");
            botao += Environment.NewLine;

            return botao;
        }
    }
    public interface IBotaoLinkExemplo
    {
        public string BotaoLinkExemplo();
    }
}
