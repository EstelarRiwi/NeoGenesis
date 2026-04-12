using System.Threading;

namespace NeoGenesis.UI;

public static class ScreenEffects
{
    public static void ShowError()
    {
        Console.WriteLine("\nInvalid option.");
        Pause();
    }

    public static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public static void LoadMainScreen()
    {
        int progress = 0;
        int barWidth = 30;

        while (progress <= 100)
        {
            Console.Clear();

            Console.WriteLine(@"              __");
            Console.WriteLine(@"             / _)");
            Console.WriteLine(@"    _.----._/ /");
            Console.WriteLine(@"   /         /");
            Console.WriteLine(@"__/ (  | (  |");
            Console.WriteLine(@"/__.-'|_|--|_|");

            Console.WriteLine("\n   DINOSAUR CHARGING...\n");

            int fill = (progress * barWidth) / 100;
            string bar = "[";

            for (int i = 0; i < barWidth; i++)
            {
                if (i < fill)
                    bar += "=";
                else if (i == fill)
                    bar += ">";
                else
                    bar += ".";
            }

            bar += $"] {progress}%";
            Console.WriteLine("   " + bar);

            progress += 2;
            Thread.Sleep(80);
        }

        Console.WriteLine("\n    COMPLETADO");
        Thread.Sleep(800);
    }

    public static void LoadConsultationScreen()
    {
        int progress = 0;
        int barWidth = 30;

        while (progress <= 100)
        {
            Console.Clear();

            Console.WriteLine(@"                         _   _");
            Console.WriteLine(@"                        | \ / |");
            Console.WriteLine(@"                        |  X  |");
            Console.WriteLine(@"                       /| / \ |\");
            Console.WriteLine(@"                      / |/   \| \");
            Console.WriteLine(@"    ________________ /__|______|__\");
            Console.WriteLine(@"   /________________\  |      |   \");
            Console.WriteLine(@"   \________________/__|______|____/");
            Console.WriteLine(@"                    \__|______|__/");

            Console.WriteLine("\n      ACCESSING SECTOR...\n");

            int fill = (progress * barWidth) / 100;
            string bar = "[";

            for (int i = 0; i < barWidth; i++)
            {
                if (i < fill)
                    bar += "#";
                else if (i == fill)
                    bar += ">";
                else
                    bar += " ";
            }

            bar += $"] {progress}%";
            Console.WriteLine("   " + bar);

            progress += 2;
            Thread.Sleep(80);
        }

        Console.WriteLine("\n    ACCESS GRANTED");
        Thread.Sleep(800);
    }
}