using Demo.DataAccessesLayer.Data.Contexts;
using Demo.DataAccessesLayer.Data.Repository.Interfaces;
using Demo.DataAccessesLayer.Models.DepartementModule;
using Demo.DataAccessesLayer.Models.EmpolyeeModule;

namespace Demo.DataAccessesLayer.Data.Repository.Classes
{
    public class EmployeeRepository(ApplicationDBContext applicationDBContext) : GenaricRepository<Empolyee>(applicationDBContext)
        , IEmployeeRepository
    {
    }
}
