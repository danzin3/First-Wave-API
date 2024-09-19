using Application.UseCases.Word.RequestsDto;
using Microsoft.AspNetCore.Mvc;

namespace First_Wave_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WordController : MainController
    {
        [HttpPost]
        public IActionResult Create([FromBody] CreateWordDto createWordDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }
    }
}
