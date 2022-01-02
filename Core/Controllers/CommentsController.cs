using System.Threading.Tasks;
using Core.DTOs;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;

        public CommentsController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CommentCreateDTO commentCreateDTO)
        {
            var comment = commentCreateDTO.ToModel();
            await _commentRepository.SaveAsync(comment);

            return NoContent();
        }
    }
}
