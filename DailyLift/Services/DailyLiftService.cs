using DailyLift.Data;
using DailyLift.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyLift.Services
{
    public class DailyLiftService
    {
        private readonly AppDbContext _db;

        public DailyLiftService(AppDbContext db)
        {
            _db = db;
        }

        public LiftItem? GetTodaysLift()
        {
            var items = _db.LiftItems
                .OrderBy(x => x.Id)
                .ToList();

            if (!items.Any())
                return null;

            var seed = DateTime.UtcNow.Date.GetHashCode();

            var random = new Random(seed);

            int index = random.Next(items.Count);

            return items[index];
        }

        public LiftItem? GetRandomLift(string? category = null)
        {
            var query = _db.LiftItems.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category)
                && category != "All")
            {
                query = query.Where(x => x.Category == category);
            }

            var items = query.ToList();

            if (!items.Any())
                return null;

            var random = new Random();

            int index = random.Next(items.Count);

            return items[index];
        }
    }
}