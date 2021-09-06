using Microsoft.EntityFrameworkCore;
using MultiDataSourceGenericRepository.Models.DataSourceBetaEntities;

namespace MultiDataSourceGenericRepository.Contexts
{
    public class BetaContext : DbContext
    {
        public DbSet<BetaOne> BetaOnes { get; set; }
        public DbSet<BetaTwo> BetaTwos { get; set; }
        public DbSet<BetaThree> BetaThrees { get; set; }
    }
}
