namespace NeoGenesis.UI;

public static class MenuArt
{
    public static void DrawMainDinosaur()
    {
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
    }

    public static void DrawMainTitle()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║        DINO MANAGER          ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.ResetColor();
    }

    public static void DrawMainMenu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("  ╔══════════════════════════════╗");
        Console.WriteLine("  ║     🦕  DINO MANAGER  🦕     ║");
        Console.WriteLine("  ╠══════════════════════════════╣");
        Console.WriteLine("  ║  [1]  add dinosaur           ║");
        Console.WriteLine("  ║  [2]  see dinosaur           ║");
        Console.WriteLine("  ║  [3]  update dinosaur        ║");
        Console.WriteLine("  ║  [4]  deleted dinosaur       ║");
        Console.WriteLine("  ║  [5]  exit                   ║");
        Console.WriteLine("  ╚══════════════════════════════╝");
        Console.ResetColor();
    }

    public static void DrawConsultationTitle()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║           GENERAL CONSULTATIONS           ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.ResetColor();
    }

    public static void DrawConsultationMenu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║  1. List all dinosaurs                    ║");
        Console.WriteLine("║  2. Search dinosaur by ID                 ║");
        Console.WriteLine("║  3. Search by registration code           ║");
        Console.WriteLine("║  4. List by park zone                     ║");
        Console.WriteLine("║  5. List by park sector                   ║");
        Console.WriteLine("║  6. List dinosaurs older than age         ║");
        Console.WriteLine("║  7. List by type                          ║");
        Console.WriteLine("║  8. Scientific reports                    ║");
        Console.WriteLine("║  9. Count all dinosaurs                   ║");
        Console.WriteLine("║ 10. Count dinosaurs by zone               ║");
        Console.WriteLine("║ 11. Count dinosaurs by sector             ║");
        Console.WriteLine("║ 12. Without tracking device               ║");
        Console.WriteLine("║ 13. Without location                      ║");
        Console.WriteLine("║ 14. Latest dinosaurs registered           ║");
        Console.WriteLine("║ 15. Order by specie                       ║");
        Console.WriteLine("║  0. Back to main menu                     ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.ResetColor();
    }
}