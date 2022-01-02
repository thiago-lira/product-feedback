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
        public async Task<IActionResult> GetAsync(int id)
        {
            var user = await _userRepository.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(new UserReadDTO(user));
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
