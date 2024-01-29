namespace Rollbard.Models
{
    public class Forktale(string name, string description)
    {
        public string Description { get; set; } = description;
        public string Name { get; set; } = name;
        public ForktaleNode? StartingNode { get; set; }
    }
}