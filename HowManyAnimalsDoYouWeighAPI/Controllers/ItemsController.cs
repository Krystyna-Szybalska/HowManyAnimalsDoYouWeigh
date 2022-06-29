using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowManyAnimalsDoYouWeighAPI;
using HowManyAnimalsDoYouWeighAPI.Items;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HowManyAnimalsDoYouWeighAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController
    {
        private ApplicationDbContext _context;
        public ItemsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<List<ItemDto>> Get()
        {
            var items = await _context.Items.ToListAsync();
            return items.Select(a => a.Adapt<ItemDto>()).ToList();
        }
        
        [HttpGet("result")]
        public async Task<List<ItemResultDto>> GetResult()
        {
            var items = await _context.Items.ToListAsync();
            return items.Select(a => a.Adapt<ItemResultDto>()).ToList();
        }
    }
}