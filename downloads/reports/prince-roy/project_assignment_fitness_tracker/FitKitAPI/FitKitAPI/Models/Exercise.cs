using System.ComponentModel.DataAnnotations;

namespace FitKitAPI.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }

        public string Name { get; set; }

        public string MuscleGroup { get; set; }

        public string Equipment { get; set; }

        public string Difficulty { get; set; }
    }
}
