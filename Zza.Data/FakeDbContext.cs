using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.Entities;

namespace Zza.Data
{
    public class FakeDbContext
    {
        public static ICollection<Customer> Customers  = new Collection<Customer>();
        public static ICollection<Order> Orders = new Collection<Order>();
        public static ICollection<OrderItem> OrderItems= new Collection<OrderItem>();
        public static ICollection<OrderStatus> OrderStatuses = new Collection<OrderStatus>();
        public static ICollection<Product> Products = new Collection<Product>();

        public FakeDbContext()
        {
            for (var i = 1; i < 30; i++)
            {
                Customers.Add(new Customer()
                {
                    FirstName = "FirstName" + i,
                    LastName = "LastName" + i,
                    City = "City" + i,
                    State = "LA",
                    Id = Guid.NewGuid(),
                    Email = "customer" + i + "@customers.com",
                    Phone = "3333333333",
                    Street = "123 Main St.",
                    Zip = "71201"
                });


                Products.Add(new Product()
                {
                    Id = i,
                    Description = "Awesome product " + i,
                    Name = "Awesomeness! " + i,
                    Type = "Type" + i
                });

            }
        }
    }
}
