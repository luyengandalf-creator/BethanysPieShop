using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;
        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Pie>> GetAllAsync()
        {
            return await _appDbContext.Pies.AsNoTracking()
            .Include(p => p.Category)
            .OrderBy(p => p.PieId)
            .ToListAsync();
        }

        public async Task<Pie?> GetByidAsync(int id)
        {
            return await _appDbContext.Pies.AsNoTracking()
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.PieId == id);
        }
        public Task<List<Pie>> GetByCategoryAsync(string categoryName)
        {
            var name = categoryName.Trim();
            var lower = name.ToLowerInvariant();
            return _appDbContext.Pies.AsNoTracking()
            .Include(p => p.Category)
            .Where(p => p.Category != null && p.Category.CategoryName.ToLower() == lower)
            .OrderBy(p => p.PieId)
            .ToListAsync();
        }

        public async Task<List<Pie>> GetPiesOfTheWeek()
        {
            return await _appDbContext.Pies.AsNoTracking()
            .Where(p => p.IsPieOfTheWeek)
            .OrderBy(p => p.PieId)
            .ToListAsync();
        }
    }
}