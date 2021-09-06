using MultiDataSourceGenericRepository.Models;

namespace MultiDataSourceGenericRepository.Interfaces.AlphaInterfaces
{
    public interface IAlphaRepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
    }
}
