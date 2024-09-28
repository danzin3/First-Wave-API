using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using First_Wave_API.Configs;
using Swashbuckle.AspNetCore.Annotations;
using Application.UseCases.Word.RequestsDto;
using Application.UseCases.Word.Create;

namespace First_Wave_API.Controllers
{
    [ApiController]
    [Route(AppConstants.WordsPrefixUrl)]
    [ApiVersion("1.0")]
    public class WordsController(CreateWordUseCase CreateWordUseCase) : MainController
    {
        private readonly CreateWordUseCase _createWordUseCase = CreateWordUseCase;

        [HttpPost]
        [SwaggerOperation(Summary = "Registrate a word", Description = "Send the word and wait for register", Tags = ["Words-Management, List-Words"])]
        [SwaggerResponse(StatusCodes.Status201Created, "Some Reponse description", typeof(CreateWordDto))]
        public IActionResult Create([FromBody] CreateWordDto createWordDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_createWordUseCase.Run(createWordDto));
        }
    }
}
