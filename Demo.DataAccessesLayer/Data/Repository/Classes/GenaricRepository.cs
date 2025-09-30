using Demo.DataAccessesLayer.Data.Contexts;
using Demo.DataAccessesLayer.Data.Repository.Interfaces;
using Demo.DataAccessesLayer.Models.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Demo.DataAccessesLayer.Data.Repository.Classes
{
    public class GenaricRepository<TEntity> : IGenaricRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDBContext _applicationDBContext;

        public GenaricRepository(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }

        public int Add(TEntity entity)
        {
            _applicationDBContext.Set<TEntity>().Add(entity);
            return _applicationDBContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll(bool withTracking = false)
        {
            return withTracking
                ? _applicationDBContext.Set<TEntity>().ToList()
                : _applicationDBContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity? GetById(int id)
        {
            return _applicationDBContext.Set<TEntity>().Find(id);
        }

        public int Update(TEntity entity)
        {
            _applicationDBContext.Set<TEntity>().Update(entity);
            return _applicationDBContext.SaveChanges();
        }

        public int REmove(TEntity entity)
        {
            _applicationDBContext.Set<TEntity>().Remove(entity);
            return _applicationDBContext.SaveChanges();
        }
    }
}
