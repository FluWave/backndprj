using System;
using Microsoft.EntityFrameworkCore;
using TechZone.DataAccess.Abstract;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Concrete;

public class BagItemRepository : IBagItemRepository
{
    private readonly ApplicationDbContext _context;

    public BagItemRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<BagItem> GetByIdAsync(int id)
    {
        return await _context.BagItems.FindAsync(id);
    }

    public async Task<IEnumerable<BagItem>> GetAllAsync()
    {
        return await _context.BagItems.ToListAsync();
    }

    public async Task AddAsync(BagItem bagItem)
    {
        await _context.BagItems.AddAsync(bagItem);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(BagItem bagItem)
    {
        _context.BagItems.Update(bagItem);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var bagItem = await GetByIdAsync(id);
        if (bagItem != null)
        {
            _context.BagItems.Remove(bagItem);
            await _context.SaveChangesAsync();
        }
    }
}

