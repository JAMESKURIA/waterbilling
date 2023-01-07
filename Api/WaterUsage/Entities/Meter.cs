using System.ComponentModel.DataAnnotations.Schema;
using WaterBilling.Api.Customers.Entities;
using WaterBilling.Api.Infrastructure.Entities;

namespace WaterBilling.Api.WaterUsage.Entities
{
    public class Meter
    {
        public int MeterId { get; set; }
        public string SerialNo { get; set; } = string.Empty;
        public string CurrReading { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime DiscDate { get; set; }
        public string DiscReason { get; set; } = string.Empty;
        public Customer Customer { get; set; } = new Customer();
        public int ZoneId { get; set; }
        public Zone Zone { get; set; } = new Zone();

        public Consumption Consumption = new Consumption();


    }
}