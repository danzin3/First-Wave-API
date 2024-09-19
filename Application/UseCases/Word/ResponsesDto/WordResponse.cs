using Domain.Entities;
using Domain.Interfaces.Responses;

namespace Application.UseCases.Word.ResponsesDto
{
    internal class WordResponse : ISingleResponse<WordEntity>
    {
        public WordEntity Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool? Success { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Details { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? TimingInMs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
