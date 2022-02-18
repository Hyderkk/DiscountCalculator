using DiscountCalculator;
using DiscountCalculator.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.Json;

namespace UnitTest
{
    [TestClass]
    public class DiscountCalculatorTest
    {
        public const string ClientTypeNotFound = "Client Type not found";

        [TestMethod]
        public void ValidClient()
        {
            DiscountRequest request = new DiscountRequest();

            request.ClientType = 1;
            request.Price = 20;
            request.Years = 5;

            ClientFactory clientFactory = new ClientFactory();

            var client = clientFactory.CreateClient(request);
            client.GetDiscount(request.Price);

        }

        [TestMethod]
        public void InvalidClient()
        {
            DiscountRequest request = new DiscountRequest();

            request.ClientType = 7;
            request.Price = 100;
            request.Years = 5;

            ClientFactory clientFactory = new ClientFactory();
            try
            {
                var client = clientFactory.CreateClient(request);
            }
            catch (NotSupportedException e)
            {
                // Assert
                StringAssert.Contains(e.Message, ClientTypeNotFound);
            }
        }
    }
}
