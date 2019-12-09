using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarinaBakery.Models.Repositories
{
    public class BreadRepo : IBreadRepo
    {
        private readonly KarinaBakeryDbContext context;
        public BreadRepo(KarinaBakeryDbContext context)
        {
            this.context = context;
        }
        //Adds new bread to database.
        public async Task<Bread> AddBread(Bread bread)
        {
            context.Add(bread);
            await context.SaveChangesAsync();
            return bread;
        }
        //Looks through database to check if bread exists.
        public bool BreadExists(int id)
        {
            return context.Breads.Any(b => b.Id == id);
        }

        public async Task<List<Bread>> GetAllBread()
        {
            return await context.Breads.ToListAsync();
        }

        public async Task<Bread> GetBreadById(int? id)
        {
            return await context.Breads.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Bread> RemoveBread(Bread bread)
        {
            context.Remove(bread);
            await context.SaveChangesAsync();
            return bread;
        }

        public async Task<Bread> UpdateBread(Bread bread)
        {
            context.Update(bread);
            await context.SaveChangesAsync();
            return bread;
        }
    }
}
