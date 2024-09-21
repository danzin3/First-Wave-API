using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using Application.UseCases.Word.RequestsDto;
using First_Wave_API.Configs;

namespace First_Wave_API.Controllers
{
    [ApiController]
    [Route(AppConstants.WordsPrefixUrl)]
    [ApiVersion("1.0")]
    public class WordsController : MainController
    {
        [HttpPost]
        public IActionResult Create([FromBody] CreateWordDto createWordDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(createWordDto);
        }
    }
}
