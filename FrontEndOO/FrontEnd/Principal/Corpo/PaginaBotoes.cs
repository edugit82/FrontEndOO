using FrontEndOO.FrontEnd.Botoes;

namespace FrontEndOO.FrontEnd.Principal.Corpo
{
    public class PaginaBotoes
    {
        public string MontaPagina()
        {            
            string corpo = "";
            corpo += new Botao().RegiaoBotoes();
            corpo += new Botao().BotaoPrimaryExemplo();
            corpo += new Botao().BotaoSecondaryExemplo();
            corpo += new Botao().BotaoSuccessExemplo();
            corpo += new Botao().BotaoDangerExemplo();
            corpo += new Botao().BotaoWarningExemplo();
            corpo += new Botao().BotaoInfoExemplo();
            corpo += new Botao().BotaoLightExemplo();
            corpo += new Botao().BotaoDarkExemplo();
            corpo += new Botao().BotaoLinkExemplo();

            return corpo;
        }
    }
}
