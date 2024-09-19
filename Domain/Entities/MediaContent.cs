using Domain.Entities.Base;

namespace Domain.Entities
{
    public class MediaContent(WordEntity _WordAssociated) : MainEntity
    {
        public string? ImageProfile {  get; set; }
        public string? AudioUrl { get; set; }
        public string? VideoUrl { get; set; }
        public string? WebSiteUrl { get; set; }
        public string? Comments {  get; set; }
        public WordEntity WordAssociated { get; set; } = _WordAssociated;
    }
}
