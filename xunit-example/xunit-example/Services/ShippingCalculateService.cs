namespace xunit_example.Services
{
    public class ShippingCalculateService : IShippingCalculateService
    {
        public decimal Calculate(int distanceKm)
        {
            if(distanceKm <= 5)
            {
                return 0.00M;
            }else if(distanceKm > 5 && distanceKm < 15)
            {
                return 10M;
            }
            else
            {
                return 30M;
            }
        }
    }
}
