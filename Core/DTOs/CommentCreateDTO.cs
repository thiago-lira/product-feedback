using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.DTOs
{
    public class CommentCreateDTO
    {
        [Required]
        public string Message { get; set; }
        [Required]
        public int AuthorId { get; set; }

        public Comment ToModel()
        {
            return new Comment()
            {
                AuthorId = this.AuthorId,
                Message = this.Message
            };
        }
    }
}
