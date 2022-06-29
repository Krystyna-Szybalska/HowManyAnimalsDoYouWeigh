using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowManyAnimalsDoYouWeighAPI.FunFacts;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HowManyAnimalsDoYouWeighAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalFunFactsController
    {
        private ApplicationDbContext _context;
        public AnimalFunFactsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<List<AnimalFunFactDto>> Get()
        {
            var animalFunFacts = await _context.AnimalFunFacts.ToListAsync();
            return animalFunFacts.Select(a => a.Adapt<AnimalFunFactDto>()).ToList();
        }
    }
}