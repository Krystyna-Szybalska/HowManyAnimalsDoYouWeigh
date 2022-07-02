using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowManyAnimalsDoYouWeighAPI.ItemFunFacts;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HowManyAnimalsDoYouWeighAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemFunFactsController
    {
        private ApplicationDbContext _context;
        public ItemFunFactsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<List<ItemFunFactDto>> Get()
        {
            var itemFunFacts = await _context.ItemFunFacts.ToListAsync();
            return itemFunFacts.Select(a => a.Adapt<ItemFunFactDto>()).ToList();
        }
    }
}