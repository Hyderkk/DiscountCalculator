using DiscountCalculator.DTO;
using System;
using System.Text.Json;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal result = 0;
                Console.WriteLine("Start");

                DiscountRequest request = new DiscountRequest();

                request.ClientType = 1;
                request.Price = 20;
                request.Years = 5;

                ClientFactory clientFactory = new ClientFactory();

                Console.WriteLine("Request: " + JsonSerializer.Serialize(request));
                var client = clientFactory.CreateClient(request);
                result = client.GetDiscount(request.Price);
                Console.WriteLine("Price After Discount:  " + result);
                Console.WriteLine("\n");

                // Client Tytpe Change

                request.ClientType = 2;
                request.Price = 100;
                request.Years = 4;

                Console.WriteLine("Request: " + JsonSerializer.Serialize(request));
                client = clientFactory.CreateClient(request);
                result = client.GetDiscount(request.Price);
                Console.WriteLine("Price After Discount  " + result);


                request.ClientType = 2;
                request.Price = 100;
                request.Years = 8;
                Console.WriteLine("Request: " + JsonSerializer.Serialize(request));

                client = clientFactory.CreateClient(request);
                result = client.GetDiscount(request.Price);
                Console.WriteLine("Price After Discount  " + result);

                request.Price = 70;
                result = client.GetDiscount(request.Price);
                Console.WriteLine("Price After Discount  " + result);


                request.ClientType = 7;
                request.Price = 100;
                request.Years = 8;
                Console.WriteLine("Request: " + JsonSerializer.Serialize(request));

                client = clientFactory.CreateClient(request);
                result = client.GetDiscount(request.Price);
                Console.WriteLine("Price After Discount  " + result);

                Console.WriteLine("END");
            }
            catch(Exception ex)
            {

                Console.WriteLine("Exception:  " + ex.Message);
            }
        }
    }
}
