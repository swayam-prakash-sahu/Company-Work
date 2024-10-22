using System.ComponentModel.DataAnnotations;

namespace BlogWebAPI.Models
{
    public class Blog
    {
        [Key]
        public int id { get; set; }

        public string title { get; set; }

        public string description { get; set; }
    }
}
