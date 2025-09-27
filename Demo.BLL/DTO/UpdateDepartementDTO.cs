namespace Demo.BLL.DTO
{
    public class UpdateDepartementDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? Decription { get; set; }
        public DateOnly DateOfCreation { get; set; }
    }
}
