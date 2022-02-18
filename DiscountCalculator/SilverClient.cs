using DiscountCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator
{
    public class SilverClient : Client
    {
        public SilverClient(DiscountRequest request) : base(request)
        {
            Console.WriteLine("SilverClient");
        }

        public override decimal GetDiscount(decimal price)
        {
            
            // result = price - (0.1m * price) - GetYearwiseDiscount() * (price - (0.1m * price));
            // Console.WriteLine("price - (0.1m * price) - GetYearwiseDiscount() * (price - (0.1m * price)): " + result);
            return price * (1 - 0.1m) * (1 - GetYearwiseDiscount());
        }
    }
}