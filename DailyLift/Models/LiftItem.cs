namespace DailyLift.Models
{
    public class LiftItem
    {
        public int Id { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}