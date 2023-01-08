using WaterBilling.Api.Billing.Entities;

namespace WaterBilling.Api.CustomerSupport.Entities
{
    public class PaymentHistory
    {
        public int PaymentHistoryId { get; set; }
        public string PaymentAmount { get; set; } = string.Empty;
        public int PaymentModeId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string AmountDue { get; set; } = string.Empty;
        public PaymentMode PaymentMode { get; set; } = new PaymentMode();
        public int BillId { get; set; }
        public Bill Bill { get; set; } = new Bill();
    }
}