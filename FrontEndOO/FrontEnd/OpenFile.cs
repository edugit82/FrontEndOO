namespace FrontEndOO.FrontEnd
{
    internal static class OpenFile
    {
        public static string Open(string filepath) 
        {
            string retorno = "";

            using (StreamReader filestring = File.OpenText(Environment.CurrentDirectory + filepath))
                retorno = filestring.ReadToEnd();

            return retorno;
        }
    }
}
