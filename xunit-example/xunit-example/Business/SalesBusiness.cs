using xunit_example.Repository;

namespace xunit_example.Business
{
    public class SalesBusiness
    {
        public decimal CalculateAverageMonthy(int month, int year)
        {
            var sales = SalesRepository.SearchSales(month, year);

            var salesMonthy = sales.Sum(x => x.Balance) / sales.Count();

            return Math.Round(salesMonthy, 2);
        }
    }
}
