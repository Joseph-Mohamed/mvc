//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;


//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;


//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;


//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;


//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;


//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;


//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;


//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;

using Demo.BLL.DTO;

namespace Demo.BLL.Servies.Interfaces
{
    public interface IDepartementServices
    {
        int AddDepartement(CreateDepartementDTO departementDTO);
        bool DeleteDepartement(int id);
        IEnumerable<DepartmentDTO> GetAllDepartement();
        DepartmentDetailsDTO? GetDepartementById(int id);
        void Test(int id);
        int UpdateDepartement(UpdateDepartementDTO updateDepartementDTO);
    }
}