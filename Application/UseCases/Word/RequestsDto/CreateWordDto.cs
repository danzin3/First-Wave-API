using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;
using Domain.Enums;

namespace Application.UseCases.Word.RequestsDto
{
    public class CreateWordDto
    {
        [Required(ErrorMessage = "Nome Obrigatório")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 255 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Não pode ter char especial")]
        [DefaultValue("Some Word")]
        public required string Tittle {  get; set; }

        [Required(ErrorMessage = "This is expected")]
        [EnumDataType(typeof(TypeExpression), ErrorMessage = "Must be in range...")]
        public required TypeExpression Type_Expression { get; set; }

        [EnumDataType(typeof(KindWord), ErrorMessage = "Must be in range")]
        public KindWord? Kind_Word { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be positive")]
        [DefaultValue(1)]
        public int? CountSearched { get; set; }

        [StringLength(255, MinimumLength = 2, ErrorMessage = "Translation be between 2 and 255 characters.")]
        [SwaggerSchema(Nullable = true)]
        public string? Translation { get; set; }

        [SwaggerSchema(Nullable = true)]
        public bool? Visibility { get; set; } = true;

        [StringLength(1024, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 1024 characters.")]
        [DefaultValue("Some optional description about the word")]
        [SwaggerSchema(Nullable = true)]
        public string? Comments { get; set; }
    }
}
