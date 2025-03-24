using FrontEndOO.FrontEnd.Botoes;

namespace FrontEndOO.FrontEnd.Principal.Menu
{
    public class MenuContainer
    {
        public string MontaMenuContainer() 
        {
            string botao = new Botao().BotaoDark("#menu_principal", "menu_containers");
            botao += Environment.NewLine;

            botao += OpenFile.Open(@"\wwwroot\js\objetos\menuprincipal\menucontainer.js");
            botao += Environment.NewLine;

            return botao;
        }
    }
}
