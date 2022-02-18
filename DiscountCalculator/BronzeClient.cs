using DiscountCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator
{
    public class BronzeClient : Client
    {
        public BronzeClient(DiscountRequest request) : base(request)
        {
            Console.WriteLine("BronzeClient ");
        }

        public override decimal GetDiscount(decimal price)
        {

            return price;
        }
    }
}
