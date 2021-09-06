using MultiDataSourceGenericRepository.Models;

namespace MultiDataSourceGenericRepository.Interfaces.BetaInterfaces
{
    public interface IBetaRepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
    }
}
