using MultiDataSourceGenericRepository.Contexts;
using MultiDataSourceGenericRepository.Interfaces.AlphaInterfaces;
using MultiDataSourceGenericRepository.Models;

namespace MultiDataSourceGenericRepository.Repositories.AlphaRepository
{
    public class AlphaRepositoryBase<T> : RepositoryBase<T>, IAlphaRepositoryBase<T> where T : EntityBase
    {
        public AlphaRepositoryBase(AlphaContext alphaContext)
            : base(alphaContext)
        {
        }
    }
}
