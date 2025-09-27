namespace Demo.DataAccessesLayer.Models
{
    public class Departement: BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Decription { get; set; } 

    }
}
