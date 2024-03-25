namespace WebTranslateHelper.Models.Entities
{
    public class Sentence
    {
        public Guid Id { get; set; }
        public string ForeignSentence { get; set; }
        public string NativeSentece { get; set; }
    }
}
