using NeoGenesis.Data;
using NeoGenesis.Models;
using NeoGenesis.Utils;

namespace NeoGenesis.Services
{
    public static class DinosaurServices
    {
        public static void DinosaurRegister()
        {
            Console.WriteLine("\t\t--- Dinosaur Register ---");

            string registerCode = Validations.ValidateId("\n\n\tGive me a Register Code (8 letter min): ");
                            
            if (DbContext.dinosaurs.Any(Dinosaur => Dinosaur.RegisterCode == registerCode)) 
            {
                Console.WriteLine("A Dinosaur with this Register Code already exists"); 
                return;
            }
                            
            string name = Validations.ValidateName("\n\n\tGive me a Name: ");

            string specie = Validations.ValidateName("\n\n\tGive me an Specie: ");

            string specimen = name + "-" + specie;
            
            Dinosaur newDinosaur = new Dinosaur (registerCode, name, specie, specimen);
                            
            DbContext.dinosaurs.Add(newDinosaur);
            DbContext.SaveChanges();

            Console.WriteLine("\n\n\tThe Dinosaur you added is: "); 
            newDinosaur.PrintInfo(); 
            
        }

        public static void DinosaurUpdate()
        {
            Console.WriteLine("\t\t--- Dinosaur Update ---");

            string registerCode = Validations.ValidateId("\n\n\tGive me your Dinosaur Register Code: ");

            if (!DbContext.dinosaurs.Any(Dinosaur => Dinosaur.RegisterCode == registerCode))
            {
                Console.WriteLine("A Dinosaur with this Register Code doesn't exist"); 
                return;
            }
            
            string newName = Validations.ValidateName("\n\n\tGive me a Name: ");

            string newSpecie = Validations.ValidateName("\n\n\tGive me a Specie: ");

            string newSpecimen = newName + " " + newSpecie;

            int age = Validations.ValidateInteger("\n\n\tGive me an Age: ");

            string type = Validations.ValidateType("\n\n\tGive me Type (Carnivore, Herbivore, Omnivore): ");

            Sector sector = new Sector();
            
            Zone zone = new Zone();
            
            string location = sector.Name + ", " + zone.Name;
            
            Dinosaur updateDinosaur = new Dinosaur (registerCode, newName, newSpecie, newSpecimen, age, type, location);
                            
            DbContext.dinosaurs.Update(updateDinosaur);
            DbContext.SaveChanges();

            Console.WriteLine("\n\n\tYour Dinosaur new information is: "); 
            updateDinosaur.PrintInfo(); 
        }

        public static void DinosaurDelete()
        {
            Console.WriteLine("\t\t--- Dinosaur Deletion ---");

            string registerCode = Validations.ValidateId("\n\n\tGive me your Dinosaur Register Code: ");

            var deleteDinosaur = DbContext.dinosaurs.Find(Dinosaur => Dinosaur.RegisterCode == registerCode);
            
            if (!deleteDinosaur)
            {
                Console.WriteLine("A Dinosaur with this Register Code doesn't exist"); 
                return;
            }
            
            DbContext.dinosaurs.Delete(deleteDinosaur);
            DbContext.SaveChanges();

            Console.WriteLine("\n\n\tYour Dinosaur new information is: "); 
            deleteDinosaur.PrintInfo(); 
        }
    }
}

