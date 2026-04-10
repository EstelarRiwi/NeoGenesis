using System.ComponentModel.DataAnnotations;

namespace NeoGenesis.Models;

public class Zone
{
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    public Sector Sector { get; set; }

    public ICollection<Dinosaur> Dinosaurs { get; set; }

    public Zone()
    {
        Dinosaurs = new List<Dinosaur>();
    }

    public Zone(string name, Sector sector)
    {
        Name = name;
        Sector = sector;
        Dinosaurs = new List<Dinosaur>();
    }
} 