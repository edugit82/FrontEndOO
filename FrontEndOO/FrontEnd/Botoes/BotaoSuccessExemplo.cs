namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoSuccessExemplo
    {
        public string BotaoSuccessExemplo()
        {
            string botao = this.BotaoSuccess("#regiao_botoes", "botao_success");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_success_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_success");
            botao += Environment.NewLine;

            return botao;
        }
    }

    public interface IBotaoSuccessExemplo
    {
        public string BotaoSuccessExemplo();
    }
}
