

using WaterBilling.Api.Billing.Entities;
using WaterBilling.Api.CustomerSupport.Entities;
using WaterBilling.Api.WaterUsage.Entities;

namespace WaterBilling.Api.Customers.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Msisdn { get; set; } = string.Empty;
        public int MeterId { get; set; }
        public virtual Meter Meter { get; set; } = new Meter();
        public Bill Bill { get; set; } = new Bill();
        public ICollection<Complaint> Complaints{ get; set; } = new Collection<Complaint>();

    }
}