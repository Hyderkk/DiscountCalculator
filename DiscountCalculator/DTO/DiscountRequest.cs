using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator.DTO
{
    public class DiscountRequest
    {
        public decimal Price { get; set; }

        public int ClientType { get; set; }

        public int Years { get; set; }

    }
}
