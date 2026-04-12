using NeoGenesis.Services;

namespace NeoGenesis.UI;

public class ConsultationMenu
{

    private readonly DinosaurService _service;

    public ConsultationMenu(DinosaurService service)
    {
        _service = service;
    }

    public void Show()
    {
        bool active = true;

        ScreenEffects.LoadConsultationScreen();

        while (active)
        {
            Console.Clear();

            MenuArt.DrawConsultationTitle();
            MenuArt.DrawConsultationMenu();

            Console.Write("\nSelect an option: ");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    
                    break;
                case "2":
                    Console.Write("Enter dinosaur ID: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        var dinosaurById = _service.DetailId(id);

                        if (dinosaurById == null)
                        {
                            Console.WriteLine("Dinosaur not found.");
                        }
                        else
                        {
                            Console.WriteLine($"Id: {dinosaurById.Id}");
                            Console.WriteLine($"Name: {dinosaurById.Name}");
                            Console.WriteLine($"Specie: {dinosaurById.Specie}");
                            Console.WriteLine($"Type: {dinosaurById.Type}");
                            Console.WriteLine($"Register Code: {dinosaurById.RegisterCode}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID.");
                    }
                    ScreenEffects.Pause();
                    break;
            }



        }

    }
}