namespace NeoGenesis.Utils
{
    public class Styles
    {
        public static void ValidMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ResetColor();
        }

        public static void InvalidMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ResetColor();
        }
    
    }
}

