using System.ComponentModel.DataAnnotations;

namespace NeoGenesis.Models;

public class Sector
{
    public int Id { get; set; }
    
    [MaxLength(100)]
    public String Name { get; set; }
    
     public ICollection<Zone> Zones { get; set; }

     public Sector()
     {
         Zones = new List<Zone>();
     }

     public Sector(string name)
     {
         Name = name;
         Zones = new List<Zone>();
     }
     
     
}