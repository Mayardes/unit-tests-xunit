using xunit_example.Entity;

namespace xunit_example.Repository
{
    public static class SalesRepository
    {
        public static List<SalesEntity> SearchSales(int month, int year)
        {
            return new List<SalesEntity>()
            {
                new SalesEntity()
                {
                    Date = DateTime.UtcNow,
                    Balance = 500.0M
                },
                new SalesEntity()
                {
                    Date = DateTime.UtcNow,
                    Balance = 1000.0M
                },
                new SalesEntity()
                {
                    Date = DateTime.UtcNow,
                    Balance = 5000.0M
                }
            };
        }
    }
}
