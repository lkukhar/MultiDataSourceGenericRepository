using MultiDataSourceGenericRepository.Contexts;
using MultiDataSourceGenericRepository.Interfaces.AlphaInterfaces;
using MultiDataSourceGenericRepository.Models.DataSourceAlphaEntities;

namespace MultiDataSourceGenericRepository.Repositories.AlphaRepository
{
    public class AlphaOneRepository : AlphaRepositoryBase<AlphaOne>, IAlphaOneRepository
    {
        public AlphaOneRepository(AlphaContext alphaContext)
            : base(alphaContext)
        {
        }
    }
}
