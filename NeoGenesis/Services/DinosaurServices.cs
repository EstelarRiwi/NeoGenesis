using Microsoft.EntityFrameworkCore;
using NeoGenesis.Data;
using NeoGenesis.Models;
using NeoGenesis.Utils;

namespace NeoGenesis.Services
{
    public class DinosaurServices
    {
        private readonly DataContext _context;

        public DinosaurServices(DataContext context)
        {
            _context = context;
        }
        
        public void DinosaurRegister()
        {
            Console.WriteLine("\t\t--- Dinosaur Register ---");

            string registerCode = Validations.ValidateId("\n\n\tGive me a Register Code (8 letter min): ");
                            
            if (_context.Dinosaurs.Any(dinosaur => dinosaur.RegisterCode == registerCode)) 
            {
                Console.WriteLine("A Dinosaur with this Register Code already exists"); 
                return;
            }
                            
            string name = Validations.ValidateName("\n\n\tGive me a Name: ");

            string specie = Validations.ValidateName("\n\n\tGive me an Specie: ");

            string specimen = name + "-" + specie;
            
            Dinosaur newDinosaur = new Dinosaur (registerCode, name, specie, specimen);
                            
            _context.Dinosaurs.Add(newDinosaur);
            _context.SaveChanges();

            Console.WriteLine("\n\n\tThe Dinosaur you added is: "); 
            
        }

        public void DinosaurUpdate()
        {
            Console.WriteLine("\t\t--- Dinosaur Update ---");

            string registerCode = Validations.ValidateId("\n\n\tGive me your Dinosaur Register Code: ");

            if (!_context.Dinosaurs.Any(Dinosaur => Dinosaur.RegisterCode == registerCode))
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
                            
            _context.Dinosaurs.Update(updateDinosaur);
            _context.SaveChanges();

            Console.WriteLine("\n\n\tYour Dinosaur new information is: "); 
        }

        public void DinosaurDelete()
        {
            Console.WriteLine("\t\t--- Dinosaur Deletion ---");

            string registerCode = Validations.ValidateId("\n\n\tGive me your Dinosaur Register Code: ");

            var deleteDinosaur = _context.Dinosaurs.FirstOrDefault(Dinosaur => Dinosaur.RegisterCode == registerCode);
            
            if (deleteDinosaur == null)
            {
                Console.WriteLine("A Dinosaur with this Register Code doesn't exist"); 
                return;
            }
            
            _context.Dinosaurs.Remove(deleteDinosaur);
            _context.SaveChanges();

            Console.WriteLine("\n\n\tYour Dinosaur new information is: "); 
        }
    }
}

