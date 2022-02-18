using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator
{
    public interface IClient
    {
        public decimal GetDiscount(decimal price);
    }
}
