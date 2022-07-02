using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HowManyAnimalsDoYouWeighAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController
    {
        private ApplicationDbContext _context;
        public AnimalsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<List<AnimalDto>> Get()
        {
            var animals = await _context.Animals.ToListAsync();
            return animals.Select(a => a.Adapt<AnimalDto>()).ToList();
        }
        
        [HttpGet("result")]
        public async Task<List<AnimalResultDto>> GetResult()
        {
            var animals = await _context.Animals.Include(a=>a.FunFacts).ToListAsync();
            return animals.Select(a => a.Adapt<AnimalResultDto>()).ToList();
        }
    }
}