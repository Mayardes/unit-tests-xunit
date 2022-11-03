// See https://aka.ms/new-console-template for more information
using xunit_example.Business;

decimal balanceAverageMonthy = new SalesBusiness().CalculateAverageMonthy(04,2021);
Console.WriteLine($"Average Balance Monthy is {balanceAverageMonthy}");


