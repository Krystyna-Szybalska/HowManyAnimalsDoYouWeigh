using System;
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
            // _context.Animals.Add(new Animal
            // {
            //     Id = Guid.NewGuid(),
            //     Name = "Dog (chihuahua)",
            //     Weight = 2.5m,
            //     FunFacts = new List<AnimalFunFact>
            //     {
            //         new AnimalFunFact
            //         {
            //             Id = Guid.NewGuid(),
            //             Text = "szczeka i morduje"
            //         }
            //     },
            // });
            // _context.Animals.Add(new Animal {
            //     Id = Guid.NewGuid(),
            //     Name = "Dog (beagle)",
            //     Weight = 16m,
            //     FunFacts = new List<AnimalFunFact>
            //     {
            //         new AnimalFunFact
            //         {
            //             Id = Guid.NewGuid(),
            //             Text = "wyje i tropi"
            //         }
            //     },
            // });
            // _context.SaveChanges();
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