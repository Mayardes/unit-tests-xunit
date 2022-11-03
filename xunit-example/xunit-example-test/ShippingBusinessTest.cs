using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using xunit_example.Business;
using xunit_example.Services;

namespace xunit_example_test
{
    public class ShippingBusinessTest
    {
        private readonly IShippingCalculateService _shippingCalculateService = new ShippingCalculateService();

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void ShippingBusinessTest_WhenDistanceLessOrEqualsThanFive_ShouldReturnZero(int shipping)
        {

            var shippingResult = new ShippingBusiness(_shippingCalculateService).CalculateShipping(shipping);

            Assert.Equal(0, shippingResult);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        public void ShippingBusinessTest_WhenDistanceMoreThan5AndLessThan14_ShouldReturnTen(int shipping)
        {
            var shippingResult = new ShippingBusiness(_shippingCalculateService).CalculateShipping(shipping);

            Assert.Equal(10, shippingResult);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(16)]
        public void ShippingBusinesTest_WhenDistanceMoreThan15_ShouldReturnThirty(int shipping)
        {
            var shippingResult = new ShippingBusiness(_shippingCalculateService).CalculateShipping(shipping);

            Assert.Equal(30, shippingResult);
        }
    }
}