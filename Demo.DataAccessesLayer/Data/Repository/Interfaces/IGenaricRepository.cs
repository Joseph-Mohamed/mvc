using Demo.DataAccessesLayer.Models.DepartementModule;
using Demo.DataAccessesLayer.Models.EmpolyeeModule;
using Demo.DataAccessesLayer.Models.Shared;

namespace Demo.DataAccessesLayer.Data.Repository.Interfaces
{
    public interface IGenaricRepository<TEntity> where TEntity : BaseEntity
    
    {

        int Add(TEntity entity);
        IEnumerable<TEntity> GetAll(bool withTracking = false);
        TEntity? GetById(int id);
        int REmove(TEntity entity);
        int Update(TEntity entity);

    }
}
