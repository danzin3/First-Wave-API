using Domain.Entities.Base;
using Domain.Enums;

namespace Domain.Entities
{
    public class WordEntity(string _Tittle, TypeExpression _Type_Expression, Guid _Word_Guid) : MainEntity
    {
        public string Tittle { get; set; } = _Tittle;
        public TypeExpression Type_Expression { get; set; } = _Type_Expression;
        public Guid Word_Guid { get; set; } = _Word_Guid == Guid.Empty ? Guid.NewGuid() : _Word_Guid;
        public KindWord? Kind_Word { get; set; }
        public int? CountSearched {  get; set; }
        public string? Translation { get; set; }
        public bool? Visibility { get; set; }
        public string? Comments { get; set; }
        public ICollection<Mean> Meanings { get; set; } = [];
        public ICollection<Synonym> Synonyms { get; set; } = [];
        public ICollection<MediaContent> MediaContents { get; set; } = [];
    }
}
