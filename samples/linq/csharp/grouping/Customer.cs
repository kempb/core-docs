using System.Collections.Generic;

namespace Grouping
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
