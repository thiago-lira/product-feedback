using Core.Models;

namespace Core.DTOs
{
    public class UserCreateDTO
    {
        public string Name { get; set; }
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
