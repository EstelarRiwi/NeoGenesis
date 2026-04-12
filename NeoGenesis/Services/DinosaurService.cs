using Microsoft.EntityFrameworkCore;
using NeoGenesis.Models;
using NeoGenesis.Data;

namespace NeoGenesis.Services;

public class DinosaurService
{
    private readonly DataContext _context;

    public DinosaurService(DataContext context)
    {
        _context = context;
    }
    
    public Dinosaur? DetailId(int id)
    {
        return _context.Dinosaurs
            .Include(d => d.Zone)
            .FirstOrDefault(d => d.Id == id);

    }
    
    public Dinosaur? DetailRegisterCode(string code)
    {
        return _context.Dinosaurs
            .Include(d => d.Zone)
            .FirstOrDefault(d => d.RegisterCode == code);
    }

    public List<Dinosaur> GetByZone(string zoneName)
    {
        return _context.Dinosaurs
            .Include(d => d.Zone)
            .Where(d => d.Zone.Name.ToLower() == zoneName.ToLower())
            .ToList(); 
    }

    public List<Dinosaur> GetBySector(string sectorName)
    {
        return _context.Dinosaurs
            .Include(d => d.Zone)
            .ThenInclude(z => z.Sector)
            .Where(d => d.Zone.Sector.Name.ToLower() == sectorName.ToLower())
            .ToList();
    }

    public int CountDinosaurs()
    {
        return _context.Dinosaurs
            .Count();
    }

    public int CountDinosaurByZone(string zoneName)
    {
        return _context.Dinosaurs
            .Where(d => d.Zone.Name == zoneName)
            .Count();
    }

    public int CountDinosaurBySector(string sectorName)
    {
        return _context.Dinosaurs
            .Where(d => d.Zone.Sector.Name == sectorName)
            .Count();
    }
    
    public List<Dinosaur> NoTraking()
    {
        return _context.Dinosaurs
            .Where(d => d.Location == null || d.Location == "")
            .ToList();
        //Aqui me nos falto en el model el traking osea el dispositivo rastreo tonces lo dejo asi para cuadno organice el dbContex
    }

    public List<Dinosaur> NoLocation()
    {
        return _context.Dinosaurs
            .Where(d => d.Location == null || d.Location == "")
            .ToList();
    }


    public List<string> ScientificReports()
    {
        return _context.Dinosaurs
            .Select(d => $"Name: {d.Name}, Specie: {d.Specie}, Type: {d.Type},Code: {d.RegisterCode}")
            .ToList();

    }

}