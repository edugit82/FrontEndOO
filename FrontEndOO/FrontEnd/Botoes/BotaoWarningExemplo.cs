namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoWarningExemplo
    {
        public string BotaoWarningExemplo()
        {
            string botao = this.BotaoWarning("#regiao_botoes", "botao_warning");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_warning_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_warning");
            botao += Environment.NewLine;

            return botao;
        }
    }
    public interface IBotaoWarningExemplo
    {
        public string BotaoWarningExemplo();
    }
}
