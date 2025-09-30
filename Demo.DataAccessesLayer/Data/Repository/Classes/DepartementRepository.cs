using Demo.DataAccessesLayer.Data.Contexts;
using Demo.DataAccessesLayer.Data.Repository.Interfaces;
using Demo.DataAccessesLayer.Models.DepartementModule;
using Demo.DataAccessesLayer.Models.EmpolyeeModule;
using Microsoft.EntityFrameworkCore;

namespace Demo.DataAccessesLayer.Data.Repository.Classes
{
    public class DepartementRepository(ApplicationDBContext applicationDBContext) : GenaricRepository<Departement>(applicationDBContext)
        ,IDepartementRepository
    {
       
    }
}
