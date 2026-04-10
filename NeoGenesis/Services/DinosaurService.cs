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
    
    /*
    public List<Dinosaur> DetailId(int id)
    {
        return _context.Dinosaurs
            .Include(d => d.Name)
            .Where(d => d.Id = id)
            .ToList<Dinosaur>();

    }
    */

}