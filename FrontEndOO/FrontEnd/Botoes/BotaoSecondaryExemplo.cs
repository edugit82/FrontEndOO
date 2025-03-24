namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoSecondaryExemplo
    {
        public string BotaoSecondaryExemplo()
        {
            string botao = this.BotaoSecondary("#regiao_botoes", "botao_secondary");
            botao += Environment.NewLine;
            
            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_secondary_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_secondary");
            botao += Environment.NewLine;            

            return botao;
        }
    }

    public interface IBotaoSecondaryExemplo
    {
        public string BotaoSecondaryExemplo();
    }
}
