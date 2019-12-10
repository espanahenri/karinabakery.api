using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KarinaBakery.Models.Repositories
{
    public interface IBreadRepo
    {
        public Task<List<Bread>> GetAllBread();
        public Task<Bread> GetBreadById(int? id);
        public Task<Bread> AddBread(Bread bread);
        public Task<Bread> UpdateBread(Bread bread);
        public Task<Bread> RemoveBread(Bread bread);
        public bool BreadExists(int id);
    }
}
