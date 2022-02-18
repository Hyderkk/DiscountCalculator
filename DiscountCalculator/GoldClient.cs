using DiscountCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator
{
    public class GoldClient : Client
    {
        public GoldClient(DiscountRequest request) : base(request)
        {

        }

        public override decimal GetDiscount(decimal price)
        {

            // result = price - (0.5m * price) - GetYearwiseDiscount() * (price - (0.5m * price));
            // Console.WriteLine("price - (0.5m * price) - GetYearwiseDiscount() * (price - (0.5m * price)): " + result);
            return price * (1 - 0.5m) * (1 - GetYearwiseDiscount());
        }
    }
}
