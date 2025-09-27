using Demo.BLL.DTO;
using Demo.DataAccessesLayer.Models;
using System.Runtime.Intrinsics.Arm;

namespace Demo.BLL.Factories
{
    internal static class DepartementFactory
    {
        public static DepartmentDTO ToDepartementDTO(this Departement d)
        {
            return new DepartmentDTO
            {
                DepID = d.Id,
                Code = d.Code,
                Name = d.Name,
                Decription = d.Decription,
                DateOfCreation = d.CreatedOn.HasValue
                    ? DateOnly.FromDateTime(d.CreatedOn.Value)
                    : default
            };
        }

        public static DepartmentDetailsDTO ToDepDetailsDTO(this Departement dep)
        {
            return new DepartmentDetailsDTO
            {
                Id = dep.Id,
                Code = dep.Code,
                Name = dep.Name,
                CreatedBy = dep.CreatedBy,
                IsDeleted = dep.IsDeleted,
                ModifiedBy = dep.ModifiedBy,

                CreatedOn = dep.CreatedOn.HasValue
                   ? DateOnly.FromDateTime(dep.CreatedOn.Value)
                   : null,

                ModifiedOn = dep.ModifiedOn.HasValue
                   ? DateOnly.FromDateTime(dep.ModifiedOn.Value)
                   : null,

                Description = dep.Decription
            };
        }

        public static Departement ToEntity(this CreateDepartementDTO departmentDetailsDTO)
        {
            return new Departement()
            {
                Decription = departmentDetailsDTO.Decription,
                Name = departmentDetailsDTO.Name,
                Code = departmentDetailsDTO.Code,
                // dateonly ==> datetime
                CreatedOn = departmentDetailsDTO.DateOfCreation.ToDateTime(new TimeOnly())
            };

        }

        public static Departement ToEntity(this UpdateDepartementDTO departmentDetailsDTO)
        {
            return new Departement()
            {
                Id = departmentDetailsDTO.Id,
                Decription = departmentDetailsDTO.Decription,
                Name = departmentDetailsDTO.Name,
                Code = departmentDetailsDTO.Code,
                // dateonly ==> datetime
                CreatedOn = departmentDetailsDTO.DateOfCreation.ToDateTime(new TimeOnly())
            };

        }


    }
}
