using CVManager.Core.Entities;
using CVManager.Core.Repositories.CVManager.Domain.Repositories;
using CVManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace CVManager.Infrastructure.Repositories
{
    public class CVRepository : ICVRepository
    {
        private readonly ApplicationDbContext _context;

        public CVRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CV>> GetAllAsync()
        {
            return await _context.CVs
                .Include(c => c.PersonalInformation)
                .Include(c => c.ExperienceInformation)
                .ToListAsync();
        }

        public async Task<CV> GetByIdAsync(int id)
        {
            return await _context.CVs
                .Include(c => c.PersonalInformation)
                .Include(c => c.ExperienceInformation)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(CV cv)
        {
            _context.CVs.Add(cv);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CV cv)
        {
            _context.CVs.Update(cv);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cv = await _context.CVs.FindAsync(id);
            if (cv != null)
            {
                _context.CVs.Remove(cv);
                await _context.SaveChangesAsync();
            }
        }
    }
}
