using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KarinaBakery.Models;
using KarinaBakery.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarinaBakery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IBreadRepo breadRepo;
        public ProductController(IBreadRepo breadrepo)
        {
            breadRepo = breadrepo;
        }
        
        [HttpGet("bread")]
        public async Task<IEnumerable<Bread>> GetAllBread()
        {
            return await breadRepo.GetAllBread();
        }

        
        [HttpGet("bread/{id}", Name = "GetBread")]
        public async Task<Bread> GetBread(int id)
        {
            return await breadRepo.GetBreadById(id);
        }

        // POST: api/Product
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
