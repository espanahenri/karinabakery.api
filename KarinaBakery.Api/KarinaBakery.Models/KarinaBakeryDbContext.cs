using Microsoft.EntityFrameworkCore;
using System;

namespace KarinaBakery.Models
{
    public class KarinaBakeryDbContext: DbContext
    {
        public DbSet<Bread> Breads { get; set; }
        public KarinaBakeryDbContext(DbContextOptions<KarinaBakeryDbContext> context) : base(context) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=.\SQLEXPRESS;initial catalog=KarinaBakeryDB;integrated security=True;MultipleActiveResultSets=True;");
            }
        }
    }
}
