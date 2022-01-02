using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Category : ModelBase
    {
        [Required]
        public string Title { get; set; }
    }
}
