namespace ToTheMoon
{
    public class AI
    {
        public int AICode { get; set; }

        public AI(int code)
        {
            AICode = code;
        }

        public void GetAIHelp()
        {
            Console.WriteLine($"Getting help from AI:{AICode}.");
        }
    }
}
