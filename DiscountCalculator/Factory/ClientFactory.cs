using DiscountCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculator
{
    public class ClientFactory : IClientFactory
    {
        public ClientFactory()
        {

        }

        public IClient CreateClient(DiscountRequest request)
        {
            //request.Discount = (reques"Request: t.Years > 7) ? (decimal)7 / 100 : (decimal)request.Years / 100;
            Console.WriteLine("\n");
            switch (request.ClientType.ToString())
            {
                // TODO: distribute this list of strategies into respective factories (see UserStrategyFactory)

                case "1": return new BronzeClient(request);
                case "2": return new SilverClient(request);
                case "3": return new GoldClient(request);
                case "4": return new PlatiniumClient(request);
                default: break;
            };
            // can return also exception that no client type found
            throw new System.NotSupportedException("Client Type not found");
          //  return new Client(request);


        }


    }
}
