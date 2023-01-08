using WaterBilling.Api.Customers.Entities;
using WaterBilling.Api.CustomerSupport.Entities;
using WaterBilling.Api.WaterUsage.Entities;

namespace WaterBilling.Api.Billing.Entities
{
    public class Bill
    {
        public int BillId { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public string Charges { get; set; } = string.Empty; // Consumption * TariffRate
        public string Adjustments { get; set; } = string.Empty; // Discounts | SurCharges
        public string TotalAmountDue { get; set; } = string.Empty; // Charges + Adjustments
        public string PaymentStatus { get; set; } = string.Empty; // 
        public DateTime DueDate { get; set; }
        public int MeterId { get; set; }
        public Meter Meter { get; set; } = new Meter();
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public int TariffId { get; set; }
        public Tariff Tariff { get; set; } = new Tariff();
        public int UsageHistoryId { get; set; }
        public UsageHistory UsageHistory { get; set; } = new UsageHistory();
        public PaymentHistory PaymentHistory { get; set; } = new PaymentHistory();
    }
}