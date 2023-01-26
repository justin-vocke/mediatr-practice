using MediatrPractice.Domain.Entities.Movies;
using Microsoft.EntityFrameworkCore;

namespace MediatrPractice.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
