using System.Threading.Tasks;
using Core.DTOs;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet("{id:int}")]
        [ActionName(nameof(GetAsync))]
        public IActionResult GetAsync(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CategoryCreateDTO categoryCreateDTO)
        {
            var category = categoryCreateDTO.ToModel();
            await _categoryRepository.SaveAsync(category);

            return CreatedAtAction(nameof(GetAsync), new { id = category.Id }, category);
        }
    }
}
