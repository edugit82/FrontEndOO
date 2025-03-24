namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IBotaoHtml
    {
        public string HtmlBotao => OpenFile.Open(@"\wwwroot\html\Botao.html");
    }
    public interface IBotaoHtml 
    {
        public string HtmlBotao { get; }
    }
}
