using MultiDataSourceGenericRepository.Contexts;
using MultiDataSourceGenericRepository.Interfaces.BetaInterfaces;
using MultiDataSourceGenericRepository.Models.DataSourceBetaEntities;

namespace MultiDataSourceGenericRepository.Repositories.BetaRepository
{
    public class BetaThreeRepository : BetaRepositoryBase<BetaThree>, IBetaThreeRepository
    {
        public BetaThreeRepository(BetaContext betaContext)
            : base(betaContext)
        {
        }
    }
}
