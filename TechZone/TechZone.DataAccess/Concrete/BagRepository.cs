using System;
using Microsoft.EntityFrameworkCore;
using TechZone.DataAccess.Abstract;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Concrete;

public class BagRepository : IBagRepository
{
    private readonly ApplicationDbContext _context;

    public BagRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Bag> GetByIdAsync(int id)
    {
        return await _context.Bags.FindAsync(id);
    }

    public async Task<IEnumerable<Bag>> GetAllAsync()
    {
        return await _context.Bags.ToListAsync();
    }

    public async Task AddAsync(Bag bag)
    {
        await _context.Bags.AddAsync(bag);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Bag bag)
    {
        _context.Bags.Update(bag);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var bag = await GetByIdAsync(id);
        if (bag != null)
        {
            _context.Bags.Remove(bag);
            await _context.SaveChangesAsync();
        }
    }
}

