using FrontEndOO.FrontEnd.Principal.Menu;

namespace FrontEndOO.FrontEnd.Principal.Corpo
{
    public class PaginaPrincipal
    {
        public string MontaPagina()
        {
            string html = OpenFile.Open(@"\wwwroot\html\Principal.html");
            html = html.Replace(Environment.NewLine, string.Empty);
            
            string scripts = OpenFile.Open(@"\wwwroot\js\objetos\principal\principal.js");
            scripts = scripts.Replace("$$[html]$$", html);
            scripts += Environment.NewLine;

            scripts += new MenuBotao().MontaMenuBotao();
            scripts += Environment.NewLine;

            scripts += new MenuContainer().MontaMenuContainer();
            scripts += Environment.NewLine;

            return scripts;
        }
    }
}
