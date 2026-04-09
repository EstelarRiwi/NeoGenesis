using System;

        bool activacion = true;

        while (activacion)
        {
            Console.Clear();

            // Dibujo mejorado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                 __
                / _)
       _.----._/ /
      /         /
   __/ (  | (  |
  /__.-'|_|--|_|
        🦖  RAWR 
");
            Console.ResetColor();

            // Título
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║        DINO MANAGER          ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.Write(@"       __
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
");
            Console.ResetColor();

            // Menú
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ╔══════════════════════════════╗");
            Console.WriteLine("  ║     🦕  DINO MANAGER  🦕     ║");
            Console.WriteLine("  ╠══════════════════════════════╣");
            Console.WriteLine("  ║  [1]  Agregar dinosaurio     ║");
            Console.WriteLine("  ║  [2]  Ver dinosaurios        ║");
            Console.WriteLine("  ║  [3]  Salir                  ║");
            Console.WriteLine("  ╚══════════════════════════════╝");
            Console.ResetColor();

            Console.Write("\n➤ Opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Error();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(@"=========================🦖 REGISTRO EN LA SELVA 🦖=========================");
                    Formulario();
                    break;

                case 2:
                    Ver();
                    break;

                case 3:
                    activacion = false;
                    break;

                default:
                    Error();
                    break;
            }
        }
    

    static void Formulario()
    {
        Console.Clear();
        Console.WriteLine("📝 REGISTRO DE DINOSAURIO\n");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int.TryParse(Console.ReadLine(), out int age);

        Console.Write("Specie: ");
        string specie = Console.ReadLine();

        Console.Write("Type: ");
        string type = Console.ReadLine();

        Console.Write("RegisterCode: ");
        string code = Console.ReadLine();

        Console.Write("Location: ");
        string location = Console.ReadLine();

        Console.WriteLine("\n Datos capturados.");
        Console.ReadKey();
    }

    static void Ver()
    {
        Console.Clear();
        Console.WriteLine(" (Vista simulada)\n");
        Console.WriteLine("Aquí irían los datos...");
        Console.ReadKey();
    }

    static void Error()
    {
        Console.WriteLine("\n Opción inválida");
        Console.ReadKey();
    }
