namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoLightExemplo
    {
        public string BotaoLightExemplo()
        {
            string botao = this.BotaoLight("#regiao_botoes", "botao_light");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\botoes\botao_light_exemplo.js");
            botao = botao.Replace("$$[id]$$", "#botao_light");
            botao += Environment.NewLine;

            return botao;
        }
    }
    public interface IBotaoLightExemplo
    {
        public string BotaoLightExemplo();
    }
}
