using Domain.Entities;
using Domain.Interfaces.Responses;

namespace Application.UseCases.Word.ResponsesDto
{
    public class SingleWordResponse : ISingleResponse<WordEntity>
    {
        public WordEntity? Data { get; set; }
        public bool? Success { get; set; }
        public string? Details { get; set; }
        public int? TimingInMs { get; set; }
    }
}
