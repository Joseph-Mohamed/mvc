namespace Demo.BLL.DTO
{
    public class DepartmentDTO
    {
        public int DepID { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Decription { get; set; } = string.Empty;
        public DateOnly DateOfCreation { get; set; }
    }
}
