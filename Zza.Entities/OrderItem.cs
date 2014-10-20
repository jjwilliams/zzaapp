using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zza.Entities
{
    [DataContract]
    public class OrderItem
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long OrderId { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public decimal TotalPrice { get; set; }

        public override string ToString()
        {
            return string.Format("TotalPrice: {0}, UnitPrice: {1}, Quantity: {2}, ProductId: {3}, OrderId: {4}, Id: {5}", TotalPrice, UnitPrice, Quantity, ProductId, OrderId, Id);
        }
    }
}
