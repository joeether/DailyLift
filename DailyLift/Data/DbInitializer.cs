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

            string filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "DataFiles",
                "lifts.csv");

            var items = CsvImporter.ImportLiftItems(filePath);

            context.LiftItems.AddRange(items);

            context.SaveChanges();
        }
    }
}