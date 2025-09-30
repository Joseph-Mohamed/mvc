namespace Demo.DataAccessesLayer.Models.Shared
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }// user id

        public DateTime? CreatedOn { get; set; } // the date time of createing record

        public int ModifiedBy { get; set; }
        public DateTime? ModifiedOn  { get; set; }

        public bool IsDeleted { get; set; }
    }
}
