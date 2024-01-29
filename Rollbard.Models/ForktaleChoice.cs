namespace Rollbard.Models
{
    public class ForktaleChoice(string text)
    {
        public ForktaleNode? Node { get; set; }
        public string Text { get; set; } = text;
    }
}