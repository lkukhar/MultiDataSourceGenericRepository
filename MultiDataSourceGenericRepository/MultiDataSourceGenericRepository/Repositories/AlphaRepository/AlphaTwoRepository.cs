using MultiDataSourceGenericRepository.Contexts;
using MultiDataSourceGenericRepository.Interfaces.AlphaInterfaces;
using MultiDataSourceGenericRepository.Models.DataSourceAlphaEntities;

namespace MultiDataSourceGenericRepository.Repositories.AlphaRepository
{
    public class AlphaTwoRepository : AlphaRepositoryBase<AlphaTwo>, IAlphaTwoRepository
    {
        public AlphaTwoRepository(AlphaContext alphaContext)
            : base(alphaContext)
        {
        }
    }
}
