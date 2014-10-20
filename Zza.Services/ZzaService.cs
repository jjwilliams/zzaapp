using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zza.Data;
using Zza.Entities;

namespace Zza.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ZzaService : IZzaService
    {
        readonly FakeDbContext _Context = new FakeDbContext();

        [OperationBehavior]
        public List<Product> GetProducts()
        {
            var princ = Thread.CurrentPrincipal;
            return FakeDbContext.Products.ToList();
        }

        [OperationBehavior]
        public List<Customer> GetCustomers()
        {
            return FakeDbContext.Customers.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            FakeDbContext.Orders.Add(order);
            order.OrderItems.ForEach(x => FakeDbContext.OrderItems.Add(x));
        }


    }
}
