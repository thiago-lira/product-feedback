using System.Collections.Generic;
using Core.Models;

namespace Core.DTOs
{
    public class UserReadDTO
    {
        public string Name { get; set; }
        public string Username { get; set; }

        public UserReadDTO(User user)
        {
            Name = user.Name;
            Username = user.Username;
        }
    }
}
