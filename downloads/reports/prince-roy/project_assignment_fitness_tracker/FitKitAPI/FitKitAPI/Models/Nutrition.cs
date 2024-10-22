using System.ComponentModel.DataAnnotations;

namespace FitKitAPI.Models
{
    public class Nutrition
    {
        [Key]
        public int UserId { get; set; }
        public double Calories { get; set; }
        public double Carbohydrates { get; set; }
        public double Protein { get; set; }
        public double Micronutrients { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
