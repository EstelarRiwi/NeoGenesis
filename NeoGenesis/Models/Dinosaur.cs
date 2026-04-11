using System.ComponentModel.DataAnnotations;

namespace NeoGenesis.Models;

public class Dinosaur
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    public int Age { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Specie { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Specimen { get; set; }
    

    [MaxLength(100)]
    public string Type { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string RegisterCode { get; set; }
    
    
    [MaxLength(100)]
    public string Location { get; set; }
    
    public Zone Zone { get; set; }

    public Dinosaur()
    {
    }

    public Dinosaur(int id, string name, int age, string specie, string type, string registerCode, string location, string specimen, Zone zone)
    {
        Id = id;
        Name = name;
        Age = age;
        Specie = specie;
        Type = type;
        RegisterCode = registerCode;
        Location = location;
        Specimen = specimen;
        Zone = zone;
    }
    

}