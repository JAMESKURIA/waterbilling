using WaterBilling.Api.Customers.Entities;

namespace WaterBilling.Api.CustomerSupport.Entities
{
    public class Complaint
    {
        public int ComplaintId { get; set; }
        public DateTime ComplaintDateFiled { get; set; }
        public string ComplaintDesc { get; set; } = string.Empty;
        public string Status { get; set; } = "O";  // Open | In Progress | Resolved | Closed | On Hold | Escalated | Cancelled | Re Opened 
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
    }
}