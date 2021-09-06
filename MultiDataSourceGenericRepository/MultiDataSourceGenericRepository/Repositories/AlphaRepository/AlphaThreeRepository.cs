using MultiDataSourceGenericRepository.Contexts;
using MultiDataSourceGenericRepository.Interfaces.AlphaInterfaces;
using MultiDataSourceGenericRepository.Models.DataSourceAlphaEntities;

namespace MultiDataSourceGenericRepository.Repositories.AlphaRepository
{
    public class AlphaThreeRepository : AlphaRepositoryBase<AlphaThree>, IAlphaThreeRepository
    {
        public AlphaThreeRepository(AlphaContext alphaContext)
            : base(alphaContext)
        {
        }
    }
}
