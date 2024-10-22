using System.ComponentModel.DataAnnotations;

namespace FitKitWebApp.Models
{
    public class UserDetails
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [Range(1, double.PositiveInfinity, ErrorMessage = "The field {0} should be greater than {1}")]
        public int Age { get; set; }

        public string Gender { get; set; }

        public decimal Weight { get; set; }

        public decimal Height { get; set; }

        public string FitnessGoals { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }
    }
}
