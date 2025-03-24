namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoPrimaryExemplo
    {
        public string BotaoPrimaryExemplo()
        {
            string botao = this.BotaoPrimary("#regiao_botoes", "botao_primary");
            botao += Environment.NewLine;            

            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_primary_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_primary");
            botao += Environment.NewLine;            

            return botao;
        }
    }

    public interface IBotaoPrimaryExemplo
    {
        public string BotaoPrimaryExemplo();
    }
}
