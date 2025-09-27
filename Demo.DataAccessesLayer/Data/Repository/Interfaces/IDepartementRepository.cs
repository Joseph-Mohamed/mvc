namespace Demo.DataAccessesLayer.Data.Repository.Interfaces
{
    public interface IDepartementRepository
    {
        int Add(Departement departement);
        IEnumerable<Departement> GetAll(bool withTracking = false);
        Departement? GetById(int id);
        int REmove(Departement departement);
        int Update(Departement departement);
    }
}