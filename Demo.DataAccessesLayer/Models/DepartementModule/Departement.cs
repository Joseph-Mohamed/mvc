using Demo.DataAccessesLayer.Models.Shared;

namespace Demo.DataAccessesLayer.Models.DepartementModule
{
    public class Departement: BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Decription { get; set; } 

    }
}
