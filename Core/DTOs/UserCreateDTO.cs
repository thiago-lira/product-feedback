using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.DTOs
{
    public class UserCreateDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }

        public User ToModel()
        {
            return new User()
            {
                Name = this.Name,
                Username = this.Username
            };
        }
    }
}
