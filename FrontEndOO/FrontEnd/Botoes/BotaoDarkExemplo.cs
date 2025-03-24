namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoDarkExemplo
    {
        public string BotaoDarkExemplo()
        {
            string botao = this.BotaoDark("#regiao_botoes", "botao_dark");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_dark_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_dark");
            botao += Environment.NewLine;

            return botao;
        }
    }
    public interface IBotaoDarkExemplo
    {
        public string BotaoDarkExemplo();
    }
}
