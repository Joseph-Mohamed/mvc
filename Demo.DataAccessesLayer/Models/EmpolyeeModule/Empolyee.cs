using Demo.DataAccessesLayer.Models.Shared;

namespace Demo.DataAccessesLayer.Models.EmpolyeeModule
{
    public class Empolyee : BaseEntity
    {
        public string Name { get; set; } = null;
        public int Age { get; set; }
        public string? Address { get; set; }

        public decimal Salary { get; set; }
        public bool IsActive { get; set; }

        public string? Email { get; set; }

        public string? PhoneNUmber { get; set; }

        public DateOnly HiringData { get; set; }

        // gender ==> enum [fmale , male]
        // empolyee ==> parttimeempolyee , fulltimeempolyee

        public EmpolyeeType EmpolyeeType { get; set; }

        public Gender gender { get; set; }




    }
}
