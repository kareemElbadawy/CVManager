using CVManager.Application.DTOs.CV;

namespace CVManager.Application.Services
{
    public interface ICVService
    {
        Task<IEnumerable<CVDto>> GetAllAsync();
        Task<CVDto> GetByIdAsync(int id);
        Task AddAsync(CVDto cvDto);
        Task UpdateAsync(CVDto cvDto);
        Task DeleteAsync(int id);
    }
}