using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Domain.Enums;

namespace Application.UseCases.Word.RequestsDto
{
    public class CreateWordDto
    {
        [Required(ErrorMessage = "Nome Obrigatório")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 255 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Não pode ter char especial")]
        public required string Tittle {  get; set; }

        [Required(ErrorMessage = "This is expected")]
        [EnumDataType(typeof(TypeExpression), ErrorMessage = "Must be in range...")]
        [JsonConverter(typeof(TypeExpression))]
        public required TypeExpression Type_Expression { get; set; }

        [EnumDataType(typeof(KindWord), ErrorMessage = "Must be in range")]
        [JsonConverter(typeof(KindWord))]
        public KindWord? Kind_Word { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be positive")]
        public int? CountSearched { get; set; }

        [StringLength(255, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 255 characters.")]
        public string? Translation { get; set; }
        public bool? Visibility { get; set; } = true;

        [StringLength(1024, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 1024 characters.")]
        public string? Comments { get; set; }
    }
}
