using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Comment : ModelBase
    {
        public int AuthorId { get; set; }
        [Required]
        public virtual User Author { get; set; }
        [Required]
        public string Message { get; set; }

    }
}
