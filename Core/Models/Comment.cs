using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Comment : ModelBase
    {
        [Required]
        public User author { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
