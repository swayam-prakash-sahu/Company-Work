namespace EmployeeDirectoryWebApplication.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedBy { get; set; }
        public int EmployeeId { get; set; }

        public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    }
}
