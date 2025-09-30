namespace Demo.Presentation.ViewModels
{
    public class DepartementEditViewModel
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Descrption { get; set; }
        public DateOnly CreatedOn { get; set; }


    }
}
