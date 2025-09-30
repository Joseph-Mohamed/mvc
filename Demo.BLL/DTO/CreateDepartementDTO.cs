using System.ComponentModel.DataAnnotations;

namespace Demo.BLL.DTO
{
    public class CreateDepartementDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        //[Required(ErrorMessage = "code is required !!")]

        public string Code { get; set; } = string.Empty;
        public string? Decription { get; set; }
        public DateOnly DateOfCreation { get; set; }
    }
}
