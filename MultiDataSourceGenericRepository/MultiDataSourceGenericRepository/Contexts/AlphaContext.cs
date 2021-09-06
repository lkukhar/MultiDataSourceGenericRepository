using Microsoft.EntityFrameworkCore;
using MultiDataSourceGenericRepository.Models.DataSourceAlphaEntities;

namespace MultiDataSourceGenericRepository.Contexts
{
    public class AlphaContext : DbContext
    {
        public DbSet<AlphaOne> AlphaOnes { get; set; }
        public DbSet<AlphaTwo> AlphaTwos { get; set; }
        public DbSet<AlphaThree> AlphaThrees { get; set; }
    }
}
