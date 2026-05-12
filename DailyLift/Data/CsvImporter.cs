using CsvHelper;
using DailyLift.Models;
using System.Globalization;

namespace DailyLift.Data
{
    public static class CsvImporter
    {
        public static List<LiftItem> ImportLiftItems(string filePath)
        {
            var items = new List<LiftItem>();

            using var reader = new StreamReader(filePath);

            using var csv = new CsvReader(
                reader,
                CultureInfo.InvariantCulture);

            csv.Read();
            csv.ReadHeader();

            while (csv.Read())
            {
                var item = new LiftItem
                {
                    Category = csv.GetField("Category") ?? "",
                    Title = csv.GetField("Title") ?? "",
                    Content = csv.GetField("Content") ?? "",
                    Combined = csv.GetField("Combined") ?? ""
                };

                items.Add(item);
            }

            return items;
        }
    }
}