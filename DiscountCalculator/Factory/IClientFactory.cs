using DiscountCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator
{
    public interface IClientFactory
    {
        IClient CreateClient(DiscountRequest request);

    }
}
