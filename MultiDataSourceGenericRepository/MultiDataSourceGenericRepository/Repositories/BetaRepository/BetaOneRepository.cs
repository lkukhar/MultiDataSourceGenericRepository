using MultiDataSourceGenericRepository.Contexts;
using MultiDataSourceGenericRepository.Interfaces.BetaInterfaces;
using MultiDataSourceGenericRepository.Models.DataSourceBetaEntities;

namespace MultiDataSourceGenericRepository.Repositories.BetaRepository
{
    public class BetaOneRepository : BetaRepositoryBase<BetaOne>, IBetaOneRepository
    {
        public BetaOneRepository(BetaContext betaContext)
            : base(betaContext)
        {
        }
    }
}
