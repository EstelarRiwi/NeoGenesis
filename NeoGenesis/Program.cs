using System;
using System.Threading;

class menu
{
    static void Main()
    {
        bool activacion = true;

        Loaded.Load();

        while (activacion)
        {
            Console.Clear();

            // Dinosaurio
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                 __
                / _)
       _.----._/ /
      /         /
   __/ (  | (  |
  /__.-'|_|--|_|
          RAWR 
");
            Console.ResetColor();

            // Título
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║        DINO MANAGER          ║");
            Console.WriteLine("╚══════════════════════════════╝");

            Console.WriteLine(@"
       __
      /oo\
     |    |
 ^^  (vvvv)   ^^
 \\  /\__/\  //
  \\/      \//
   /        \        
  |          |    ^  
  /          \___/ | 
 (            )     |
  \----------/     /
    //    \\_____/
   W       W
BUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU!!!!!!!!!!!!!!!!!!!!!!!!!!!!
");

            Console.ResetColor();

            // Menú
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ╔══════════════════════════════╗");
            Console.WriteLine("  ║     🦕  DINO MANAGER  🦕     ║");
            Console.WriteLine("  ╠══════════════════════════════╣");
            Console.WriteLine("  ║  [1]  add dinosaur           ║");
            Console.WriteLine("  ║  [2]  see dinosaur           ║");
            Console.WriteLine("  ║  [3]  deleted dinosaur       ║");
            Console.WriteLine("  ║  [4]  deleted dinosaur       ║");
            Console.WriteLine("  ║  [5]  exit                   ║");
            Console.WriteLine("  ╚══════════════════════════════╝");
            Console.ResetColor();

            Console.Write("\n Opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Error();
                continue;
            }

            switch (opcion)
            {
                case 1:
                
                    break;
                case 2:
                    break;

                case 3:
                    activacion = false;
                    break;
                case 4:
                    submenu();
                    break;
                case 5:
                    activacion = false;
                    break;

                default:
                    Error();
                    break;
            }
        }
    }


    static void submenu()
    {
        bool activacion = true;
        while (activacion)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║       GENERAL CONSULTATIONS      ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            Console.WriteLine("║  1. List all dinosaurs           ║");
            Console.WriteLine("║  2. Search dinosaur by ID        ║");
            Console.WriteLine("║  3. Search by registration code  ║");
            Console.WriteLine("║  4. List by park zone            ║");
            Console.WriteLine("║  5. List by park sector          ║");
            Console.WriteLine("║  0. <- Back to main menu         ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.Write("\nSelect an option: ");
            string opcionSub1 = Console.ReadLine();
        }
    }

    static void Error()
    {
        Console.WriteLine("\nOpción inválida");
        Console.ReadKey();
    }
}

class Loaded
{
    public static void Load()
    {
        int progreso = 0;
        int anchoBarra = 30;

        while (progreso <= 100)
        {
            Console.Clear();

            Console.WriteLine(@"              __");
            Console.WriteLine(@"             / _)");
            Console.WriteLine(@"    _.----._/ /");
            Console.WriteLine(@"   /         /");
            Console.WriteLine(@"__/ (  | (  |");
            Console.WriteLine(@"/__.-'|_|--|_|");

            Console.WriteLine("\n   DINOSAUR CHARGING...\n");

            int llenado = (progreso * anchoBarra) / 100;
            string barra = "[";

            for (int i = 0; i < anchoBarra; i++)
            {
                if (i < llenado)
                    barra += "=";
                else if (i == llenado)
                    barra += ">";
                else
                    barra += ".";
            }

            barra += $"] {progreso}%";
            Console.WriteLine("   " + barra);

            progreso += 2;

            Thread.Sleep(80);
        }

        Console.WriteLine("\n    COMPLETADO");
        Thread.Sleep(800);
    }
    
}