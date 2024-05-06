namespace WebTranslateHelper.Models.Entities
{
    public class Sentence
    {
        public Guid Id { get; set; }
        public required string ForeignSentence { get; set; }
        public string? NativeSentence { get; set; }
    }
}
