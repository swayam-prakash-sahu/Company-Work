using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitKitAPI.Models
{
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserCredential? UserCredential { get; set; }

        public int ExerciseId { get; set; }

        [ForeignKey("ExerciseId")]
        public Exercise? Exercise { get; set; }

        public DateTime Date { get; set; }

        public string? Intensity { get; set; }

        public decimal Duration { get; set; }

        public int Sets { get; set; }

        public int Repetitions { get; set; }

        public string? Notes { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }
    }
}
