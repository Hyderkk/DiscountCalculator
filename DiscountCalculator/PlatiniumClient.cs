using DiscountCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator
{
    public class PlatiniumClient : Client
    {
        public PlatiniumClient(DiscountRequest request) : base(request)
        {

        }

        public override decimal GetDiscount(decimal price)
        {
            // result = price - (0.6m * price) - GetYearwiseDiscount() * (price - (0.6m * price));
            // Console.WriteLine("price - (0.6m * price) - GetYearwiseDiscount() * (price - (0.6m * price)): " + result);
            return price * (1 - 0.6m) * (1 - GetYearwiseDiscount());
        }
    }
}
