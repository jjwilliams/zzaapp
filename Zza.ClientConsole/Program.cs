using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.ClientConsole.ZzaServices;
using Zza.Entities;

namespace Zza.ClientConsole
{
    class Program
    {
        private static readonly ZzaServiceClient Proxy = new ZzaServiceClient("NetTcpBinding_IZzaService");
        static void Main(string[] args)
        {
            LoadProductsAndCustomers();
            SubmitOrder();
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }

        static async void LoadProductsAndCustomers()
        {
            var test = await Proxy.GetProductsAsync();
            test.ToList().ForEach(Console.WriteLine);
        }

        static void SubmitOrder()
        {
            Order order = new Order()
            {
                CustomerId = Guid.NewGuid(),
                Id = 3,
                ItemsTotal = 3,
                OrderStatusId = 3,
                OrderItems =
                    new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Id = 1,
                            OrderId = 3,
                            ProductId = 3,
                            Quantity = 3,
                            TotalPrice = 33,
                            UnitPrice = 11
                        }
                    }

            };
            Proxy.SubmitOrder(order);
            Proxy.Close();
        }
    }
}
