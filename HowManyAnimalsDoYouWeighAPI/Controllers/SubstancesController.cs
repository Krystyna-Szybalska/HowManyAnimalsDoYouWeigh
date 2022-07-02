using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowManyAnimalsDoYouWeighAPI.Items;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HowManyAnimalsDoYouWeighAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubstancesController
    {
        private ApplicationDbContext _context;
        public SubstancesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<List<SubstanceDto>> Get()
        {
            var substances = await _context.Substances.ToListAsync();
            return substances.Select(a => a.Adapt<SubstanceDto>()).ToList();
        }
        
        [HttpGet("result")]
        public async Task<List<SubstanceResultDto>> GetResult()
        {
            var substances = await _context.Substances.ToListAsync();
            return substances.Select(a => a.Adapt<SubstanceResultDto>()).ToList();
        }
    }
}