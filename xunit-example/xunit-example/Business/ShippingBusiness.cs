using xunit_example.Services;

namespace xunit_example.Business
{
    public class ShippingBusiness
    {
        private readonly IShippingCalculateService _shippingCalculateService;
        public ShippingBusiness(IShippingCalculateService shippingCalculateService)
        {
            _shippingCalculateService = shippingCalculateService;
        }
        public decimal CalculateShipping(int distanceKm)
        {
            return _shippingCalculateService.Calculate(distanceKm);
        }
    }
}
