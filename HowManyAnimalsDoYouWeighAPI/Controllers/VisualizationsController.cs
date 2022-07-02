using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowManyAnimalsDoYouWeighAPI.Visualizations;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HowManyAnimalsDoYouWeighAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisualizationsController
    {
        private ApplicationDbContext _context;
        public VisualizationsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<List<VisualizationDto>> Get()
        {
            var visualizations = await _context.Visualizations.ToListAsync();
            return visualizations.Select(a => a.Adapt<VisualizationDto>()).ToList();
        }
    }
}