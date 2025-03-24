namespace FrontEndOO.FrontEnd.Botoes
{
    public partial class Botao : IRegiaoBotoes
    {
        public string RegiaoBotoes()
        {
            
            string div = OpenFile.Open(@"\wwwroot\html\Div.html");
            string regiao = OpenFile.Open(@"\wwwroot\js\objetos\botoes\regiao_botoes.js");
            regiao = regiao.Replace("$$[div]$$", div);
            regiao = regiao.Replace("$$[id]$$", "regiao_botoes");
            regiao += Environment.NewLine;

            return regiao;
        }
    }
    public interface IRegiaoBotoes
    {
        public string RegiaoBotoes();
    }
}
