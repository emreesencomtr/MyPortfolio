using MyPortfolio.Models;

namespace MyPortfolio.Data
{
    public static class FakeDatabase
    {
        public static List<User> Users = new List<User>
    {
        new User { Id = 1, Email = "admin@admin.com", Password = "1234" },
        new User { Id = 2, Email = "admin@example.com", Password = "admin" }
    };
    }
}
