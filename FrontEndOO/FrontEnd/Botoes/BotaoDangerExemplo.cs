namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoDangerExemplo
    {
        public string BotaoDangerExemplo()
        {
            string botao = this.BotaoDanger("#regiao_botoes", "botao_danger");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_danger_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_danger");
            botao += Environment.NewLine;

            return botao;
        }        
    }
    public interface IBotaoDangerExemplo
    {
        public string BotaoDangerExemplo();
    }
}
