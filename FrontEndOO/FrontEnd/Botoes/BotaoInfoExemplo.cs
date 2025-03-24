namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoInfoExemplo
    {
        public string BotaoInfoExemplo()
        {
            string botao = this.BotaoInfo("#regiao_botoes", "botao_info");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_info_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_info");
            botao += Environment.NewLine;

            return botao;
        }
    }
    public interface IBotaoInfoExemplo
    {
        public string BotaoInfoExemplo();
    }
}
