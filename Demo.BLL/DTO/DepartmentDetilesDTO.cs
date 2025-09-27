using Demo.DataAccessesLayer.Models;

namespace Demo.BLL.DTO
{
    public class DepartmentDetailsDTO
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; } // user id

        public DateOnly? CreatedOn { get; set; }// date only
        public int? ModifiedBy { get; set; }
        public DateOnly? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? Description { get; set; }

        //public DepartmentDetailsDTO(Departement dep)
        //{
        //    Id = dep.Id,
        //        Code = dep.Code,
        //        Name = dep.Name,
        //        CreatedBy = dep.CreatedBy,
        //        IsDeleted = dep.IsDeleted,
        //        ModifiedBy = dep.ModifiedBy,

        //        CreatedOn = dep.CreatedOn.HasValue
        //            ? DateOnly.FromDateTime(dep.CreatedOn.Value)
        //            : null,

        //        ModifiedOn = dep.ModifiedOn.HasValue
        //            ? DateOnly.FromDateTime(dep.ModifiedOn.Value)
        //            : null,

        //        Description = dep.Decription;
        //}

    }
}
