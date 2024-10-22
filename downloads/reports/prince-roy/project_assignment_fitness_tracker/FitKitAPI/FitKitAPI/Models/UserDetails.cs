using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitKitAPI.Models
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserCredential? UserCredential { get; set; }

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
