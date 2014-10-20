using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zza.Entities
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Zip { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}, Zip: {1}, State: {2}, City: {3}, Street: {4}, Email: {5}, Phone: {6}, LastName: {7}, FirstName: {8}", Id, Zip, State, City, Street, Email, Phone, LastName, FirstName);
        }
    }
}
