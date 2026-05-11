using DailyLift.Models;

namespace DailyLift.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.LiftItems.Any())
            {
                return;
            }

            var items = new List<LiftItem>
            {
                new LiftItem
                {
                    Category = "Dad Joke",
                    Title = "Chicken Joke",
                    Content = "Why did the chicken go to the séance? To talk to the other side."
                },

                new LiftItem
                {
                    Category = "Science Fact",
                    Title = "Bananas",
                    Content = "Bananas are slightly radioactive because they contain potassium."
                },

                new LiftItem
                {
                    Category = "Quote",
                    Title = "Roosevelt",
                    Content = "Believe you can and you're halfway there."
                }
            };

            context.LiftItems.AddRange(items);
            context.SaveChanges();
        }
    }
}