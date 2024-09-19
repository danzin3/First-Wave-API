using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Synonym(string _Tittle, WordEntity _WordAssociated) : MainEntity
    {
        public string Tittle { get; set; } = _Tittle;
        public int? Score { get; set; }
        public string? WhenUsed { get; set; }
        public WordEntity WordAssociated { get; set; } = _WordAssociated;
    }
}
