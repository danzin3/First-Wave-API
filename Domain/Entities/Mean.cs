using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Mean(string _Summary, WordEntity _WordAssociated) : MainEntity
    {
        public string Summary { get; set; } = _Summary;
        public int? Score { get; set; }
        public string? WhenUsed { get; set; }
        public WordEntity WordAssociated { get; set; } = _WordAssociated;
    }
}
