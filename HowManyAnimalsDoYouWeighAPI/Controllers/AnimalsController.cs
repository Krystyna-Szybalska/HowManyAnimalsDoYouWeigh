using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<List<Animal>> Get()
        {
            return await _context.Animals.ToListAsync();
        }
    }
}