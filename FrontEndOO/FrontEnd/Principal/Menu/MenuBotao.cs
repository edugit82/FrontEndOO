using FrontEndOO.FrontEnd.Botoes;

namespace FrontEndOO.FrontEnd.Principal.Menu
{
    public class MenuBotao
    {
        public string MontaMenuBotao() 
        {
            string botao = new Botao().BotaoDark("#menu_principal", "menu_botoes");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\menuprincipal\menubotao.js");            
            botao += Environment.NewLine;

            return botao;
        }
    }
}
