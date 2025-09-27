using Demo.DataAccessesLayer.Data.Contexts;
using Demo.DataAccessesLayer.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo.DataAccessesLayer.Data.Repository.Classes
{
    public class DepartementRepository : IDepartementRepository
    {
        private readonly ApplicationDBContext _dBContext;

        public DepartementRepository(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext ?? throw new ArgumentNullException(nameof(dBContext));
        }

        // Get all
        public IEnumerable<Departement> GetAll(bool withTracking = false)
        {
            return withTracking
                ? _dBContext.departements.ToList()
                : _dBContext.departements.AsNoTracking().ToList();
        }

        // Get by id
        public Departement? GetById(int id) => _dBContext.departements.Find(id);

        // Add
        public int Add(Departement departement)
        {
            _dBContext.Add(departement);
            return _dBContext.SaveChanges();
        }

        // Update
        public int Update(Departement departement)
        {
            _dBContext.Update(departement);
            return _dBContext.SaveChanges();
        }

        // Remove
        public int Remove(Departement departement)
        {
            _dBContext.Remove(departement);
            return _dBContext.SaveChanges();
        }

        public int REmove(Departement departement)
        {
            throw new NotImplementedException();
        }
    }
}
