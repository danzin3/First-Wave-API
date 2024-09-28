using Domain.Interfaces.Responses;
using Domain.Entities;
using Application.UseCases.Word.RequestsDto;
using Application.UseCases.Word.ResponsesDto;

namespace Application.UseCases.Word.Create
{
    public class CreateWordUseCase(ISingleResponse<WordEntity> Reponse)
    {
        private readonly ISingleResponse<WordEntity> _response = Reponse;

        public SingleWordResponse Run(CreateWordDto requestData)
        {
            // Chamada do Automapper pra converter requestData em Entity para o Repositorio
            // Chamada do repositoruio passando a entity que eu converti e pretendo salvar no banco
            Console.WriteLine("O que chegou no UseCase --> ", requestData);
            var teste = new WordEntity("Um titulo qualquer", requestData.Type_Expression);
            _response.Success = true;
            _response.Data = teste;
            return (SingleWordResponse)_response;
        }
    }
}
