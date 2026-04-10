using Microsoft.EntityFrameworkCore;
using NeoGenesis.Models;
using NeoGenesis.Data;

namespace NeoGenesis.Services;

public class ExampleQuery
{
    private readonly DataContext _context;

    public ExampleQuery(DataContext context)
    {
        _context = context;
    }
    
    //Print all the dinosaur
    public List<Dinosaur> GetAll ()
    {
        return _context.Dinosaurs
            .AsNoTracking()
            .ToList();
    }
    
    // Sort dinosaurs by name
    public List<Dinosaur> OrderByName ()
    {
        return _context.Dinosaurs
            .AsNoTracking()
            .OrderBy(d => d.Name)
            .ToList();
    }
    
    // Sort dinosaurs by type (carnivore,herbivore,omnivore)
    public List<Dinosaur> FilterByType (string type)
    {
        return _context.Dinosaurs
            .AsNoTracking()
            .Where(d => d.Type.ToLower() == type.ToLower())
            .ToList();
    }
    
    // Sort dinosaur older than a certain age
    public List<Dinosaur> FilterAge(int minAge)
    {
        return _context.Dinosaurs
            .AsNoTracking()
            .Where(d => d.Age > minAge)
            .ToList();
    }
}