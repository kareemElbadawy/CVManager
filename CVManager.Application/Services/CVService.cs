using AutoMapper;
using CVManager.Application.DTOs.CV;
using CVManager.Core.Entities;
using CVManager.Core.Repositories;
using CVManager.Core.Repositories.CVManager.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Services
{
    public class CVService : ICVService
    {
        private readonly ICVRepository _cvRepository;
        private readonly IMapper _mapper;

        public CVService(ICVRepository cvRepository, IMapper mapper)
        {
            _cvRepository = cvRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CVDto>> GetAllAsync()
        {
            var cvs = await _cvRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CVDto>>(cvs);
        }

        public async Task<CVDto> GetByIdAsync(int id)
        {
            var cv = await _cvRepository.GetByIdAsync(id);
            return _mapper.Map<CVDto>(cv);
        }

        public async Task AddAsync(CVDto cvDto)
        {
            var cv = _mapper.Map<CV>(cvDto);
            await _cvRepository.AddAsync(cv);
        }

        public async Task UpdateAsync(CVDto cvDto)
        {
            var cv = _mapper.Map<CV>(cvDto);
            await _cvRepository.UpdateAsync(cv);
        }

        public async Task DeleteAsync(int id)
        {
            await _cvRepository.DeleteAsync(id);
        }
    }

}
