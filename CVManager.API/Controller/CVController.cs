using AutoMapper;
using CVManager.Application.DTOs.CV;
using CVManager.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CVManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CVsController : ControllerBase
    {
        private readonly ICVService _cvService;
        private readonly IMapper _mapper;

        public CVsController(ICVService cvService, IMapper mapper)
        {
            _cvService = cvService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cvs = await _cvService.GetAllAsync();
            return Ok(cvs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cv = await _cvService.GetByIdAsync(id);
            if (cv == null)
            {
                return NotFound();
            }
            return Ok(cv);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CVDto cvDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _cvService.AddAsync(cvDto);
            return CreatedAtAction(nameof(GetById), new { id = cvDto.Id }, cvDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CVDto cvDto)
        {
            if (id != cvDto.Id || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _cvService.UpdateAsync(cvDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _cvService.DeleteAsync(id);
            return NoContent();
        }
    }
}
