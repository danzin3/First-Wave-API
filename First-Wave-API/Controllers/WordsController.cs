using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using First_Wave_API.Configs;
using Swashbuckle.AspNetCore.Annotations;
using Application.UseCases.Word.RequestsDto;

namespace First_Wave_API.Controllers
{
    [ApiController]
    [Route(AppConstants.WordsPrefixUrl)]
    [ApiVersion("1.0")]
    public class WordsController : MainController
    {
        [HttpPost]
        [SwaggerOperation(Summary = "Registrate a word", Description = "Send the word and wait for register", Tags = ["Words_Management, List_Words"])]
        [SwaggerResponse(StatusCodes.Status201Created, "Some Reponse description", typeof(CreateWordDto))]
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
