//using Demo.BLL.DTO;
//using Demo.DataAccessesLayer.Data.Repository.Classes;
//using Demo.DataAccessesLayer.Data.Repository.Interfaces;

//namespace Demo.BLL.Servies
//{
//    internal class DepartementServies
//    {
//        private readonly IDepartementRepository _departementRepository;

//        // Method ==> repository
//        // inject all in the ctor
//        // high level modules should not depend on low level module ==> Abstraction
//        public DepartementServies(IDepartementRepository departementRepository)
//        {
//            this._departementRepository = departementRepository;
//        }
//        public void test(int id)
//        {
//            var res = _departementRepository.GetById(id);
//        }

//        // Get All ==> Id , code ,name, decription , dateofcreation [date part only ]
//        public IEnumerable<DepartmentDTO> GetAllDepartement()
//        {
//            var departments = _departementRepository.GetAll();
//            var depReturnDTO = departments.Select(d => new DepartmentDTO()
//            {
//                DepID = d.Id,
//                Code = d.Code,
//                Name = d.Name,
//                Decription = d.Decription,
//                DateOfCreation = d.CreatedOn.HasValue ? DateOnly.FromDateTime
//                (d.CreatedOn.Value) : default
//            });
//            return depReturnDTO;
//        }
//        // Get By Id

//        public DepartmentDetilesDTO GetDepartementById(int id)
//        {
//            var dep = _departementRepository.GetById(id);
//            if (dep is null)
//                return null;
//            return new DepartmentDetilesDTO
//            {
//                Id = dep.Id,
//                Code = dep.Code,
//                Name = dep.Name,
//                CreatedBy = dep.CreatedBy,
//                IsDeleted = dep.IsDeleted,
//                ModifiedBy = dep.ModifiedBy,

//                // Conversion من DateTime? → DateOnly?
//                CreatedOn = dep.CreatedOn.HasValue
//            ? DateOnly.FromDateTime(dep.CreatedOn.Value)
//            : null,

//                ModifiedOn = dep.ModifiedOn.HasValue
//            ? DateOnly.FromDateTime(dep.ModifiedOn.Value)
//            : null,

//                Description = dep.Description
//            };
//        }
//    }


//        // Add
//        // Update
//        // Remove

//    }
//}


using Demo.BLL.DTO;
using Demo.BLL.Factories;
using Demo.BLL.Servies.Interfaces;
using Demo.DataAccessesLayer.Data.Repository.Interfaces;

namespace Demo.BLL.Servies.Classes
{
    public class DepartementServices : IDepartementServices
    {
        private readonly IDepartementRepository _departementRepository;

        // Inject interface, not class
        public DepartementServices(IDepartementRepository departementRepository)
        {
            _departementRepository = departementRepository;
        }

        // Just test method
        public void Test(int id)
        {
            var res = _departementRepository.GetById(id);
        }

        // Get All ==> Id , code , name, description , dateofcreation [date part only ]
        public IEnumerable<DepartmentDTO> GetAllDepartement()
        {
            var departments = _departementRepository.GetAll();
            var depReturnDTO = departments.Select(d => new DepartmentDTO
            {
                DepID = d.Id,
                Code = d.Code,
                Name = d.Name,
                Decription = d.Decription,
                DateOfCreation = d.CreatedOn.HasValue
                    ? DateOnly.FromDateTime(d.CreatedOn.Value)
                    : default
            });
            return depReturnDTO;

            //return departments.Select(d => new DepartmentDTO());
        }

        // Get By Id
        public DepartmentDetailsDTO? GetDepartementById(int id)
        {
            var dep = _departementRepository.GetById(id);
            //if (dep is null)
            //    return null;

            //* Mapping types
            // Auto mapping ==> package [AutoMapper]
            // Extention Method Mapping
            // ctor mapping

            // manual mapping

            return dep is null ? null : dep.ToDepDetailsDTO();




            //return new DepartmentDetailsDTO(dep);
        }



        // ADD
        public int AddDepartement(CreateDepartementDTO departementDTO)
        {
            var dep = departementDTO.ToEntity();
            return _departementRepository.Add(dep);
        }

        // Update 

        public int UpdateDepartement(UpdateDepartementDTO updateDepartementDTO)
        {
            var dep = updateDepartementDTO.ToEntity();
            return _departementRepository.Update(dep);
        }


        // Delete
        public bool DeleteDepartement(int id)
        {
            var dep = _departementRepository.GetById(id);
            if (dep is null) return false;
            int numOfRow = _departementRepository.REmove(dep);
            return numOfRow > 0 ? true : false;
        }


    }
}
