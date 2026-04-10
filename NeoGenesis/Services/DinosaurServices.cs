using NeoGenesis.Models;
using NeoGenesis.Utils;

namespace NeoGenesis.Services
{
    public static class DinosaurServices
    {
        public static void DinosaurRegister()
        {
            Console.WriteLine("\t\t--- Dinosaur Register ---");

            string id = Validations.ValidateId("\n\n\tGive me an Id: ");
                            
            if (DbContext.dinosaurs.Any(driver => driver.Id == id)) 
            {
                Console.WriteLine("A Dinosaur with this ID already exists"); 
                return;
            }
                            
            string name = Validations.ValidateName("\n\n\tGive me a Name: ");

            int age = Validations.ValidateInteger("\n\n\tGive me an Age: ");
            
            Dinosaur newDinosaur = new Dinosaur (id, name, license);
                            
            DbContext.drivers.Add(newDriver);
            DbContext.SaveChanges();

            Console.WriteLine("\n\n\tThe Driver you added is: "); 
            newDriver.PrintInfo(); 
            
        }
    }
}

