using Case.Entities;
using Case.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Controllers
{
    [ApiController]
    [Route("seeds")]
    public class SeedsController : Controller
    {
        private readonly SeedRepository repository;

        public SeedsController()
        {
            repository = new SeedRepository();
        }

        [HttpGet]
        public IEnumerable<Seed> GetSeeds()
        {
            return repository.GetSeeds();
        }

    }
}
