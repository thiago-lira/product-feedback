using System.Threading.Tasks;
using Core.DTOs;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{id:int}")]
        [ActionName(nameof(GetAsync))]
        public IActionResult GetAsync(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UserCreateDTO userCreateDTO)
        {
            var user = userCreateDTO.ToModel();
            await _userRepository.SaveAsync(user);

            return CreatedAtAction(nameof(GetAsync), new { id = user.Id }, user);
        }
    }
}
