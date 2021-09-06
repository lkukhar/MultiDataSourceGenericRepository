using MultiDataSourceGenericRepository.Contexts;
using MultiDataSourceGenericRepository.Interfaces.BetaInterfaces;
using MultiDataSourceGenericRepository.Models;

namespace MultiDataSourceGenericRepository.Repositories.BetaRepository
{
    public class BetaRepositoryBase<T> : RepositoryBase<T>, IBetaRepositoryBase<T> where T : EntityBase
    {
        public BetaRepositoryBase(BetaContext betaContext)
            : base(betaContext)
        {
        }
    }
}
