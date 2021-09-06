using MultiDataSourceGenericRepository.Contexts;
using MultiDataSourceGenericRepository.Interfaces.BetaInterfaces;
using MultiDataSourceGenericRepository.Models.DataSourceBetaEntities;

namespace MultiDataSourceGenericRepository.Repositories.BetaRepository
{
    public class BetaTwoRepostitory : BetaRepositoryBase<BetaTwo>, IBetaTwoRepository
    {
        public BetaTwoRepostitory(BetaContext betaContext)
            : base(betaContext)
        {
        }
    }
}
