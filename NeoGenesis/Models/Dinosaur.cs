using System.ComponentModel.DataAnnotations;

namespace NeoGenesis.Models;

public class Dinosaur
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string RegisterCode { get; set; }
    
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
    
    [MaxLength(100)]
    public string Location { get; set; }
    
    public Zone Zone { get; set; }

    public Dinosaur()
    {
    }
    
    public Dinosaur(string registerCode, string name, string specie, string specimen)
    {
        RegisterCode = registerCode;
        Name = name;
        Specie = specie;
        Specimen = specimen;
    }

    public Dinosaur(string registerCode, string name, string specie, string specimen, int age, string type, string location)
    {
        RegisterCode = registerCode;
        Name = name;
        Specie = specie;
        Specimen = specimen;
        Age = age;
        Type = type;
        Location = location;
    }
    

}