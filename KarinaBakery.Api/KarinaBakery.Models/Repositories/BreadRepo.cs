using System;
using System.Collections.Generic;
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
        public Task<Bread> AddBread(Bread bread)
        {
            throw new NotImplementedException();
        }

        public bool BreadExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Bread>> GetAllBread()
        {
            throw new NotImplementedException();
        }

        public Task<Bread> GetBreadById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Bread> RemoveBread(Bread bread)
        {
            throw new NotImplementedException();
        }

        public Task<Bread> UpdateBread(Bread bread)
        {
            throw new NotImplementedException();
        }
    }
}
