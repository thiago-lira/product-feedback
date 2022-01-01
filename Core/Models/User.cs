using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class User : ModelBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
