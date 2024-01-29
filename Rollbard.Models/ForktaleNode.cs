namespace Rollbard.Models
{
    public class ForktaleNode(string text, string title)
    {
        public IEnumerable<ForktaleChoice> Choices { get; } = [];
        public string Text { get; set; } = text;
        public string Title { get; set; } = title;
    }
}