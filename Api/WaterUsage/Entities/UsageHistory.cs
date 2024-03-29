using WaterBilling.Api.Billing.Entities;

namespace WaterBilling.Api.WaterUsage.Entities
{
    public class UsageHistory
    {
        public int UsageHistoryId { get; set; }
        public string MeterReading { get; set; } = string.Empty;
        public string AmountConsumed { get; set; } = string.Empty;
        public DateTime DateRecorded { get; set; }  
        public int MeterId { get; set; }
        public Meter Meter { get; set; } = new Meter();
        public Bill Bill { get; set; } = new Bill();
    }
}