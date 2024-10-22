using System.ComponentModel.DataAnnotations;

namespace Mvcapp2.Models
{
    public class Category
    {
        
        [Key] public int CategoryId { get; set; }
        [Required] public string Name { get; set; } 
        public int Displayorder { get; set; }
    }
}
