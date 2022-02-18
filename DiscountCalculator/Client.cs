using DiscountCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator
{
    public class Client : IClient
    {
        public DiscountRequest discountRequest { get; set; }
        public Client(DiscountRequest request)
        {
            discountRequest = request;
        }

        public virtual decimal GetDiscount(decimal price)
        {
            return price;
        }

        protected decimal GetYearwiseDiscount()
        {
           return  (discountRequest.Years > 7) ? (decimal)7 / 100 : (decimal)discountRequest.Years / 100;
        }
    }
}
