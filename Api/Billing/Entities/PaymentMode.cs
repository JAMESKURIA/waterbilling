using WaterBilling.Api.CustomerSupport.Entities;

namespace WaterBilling.Api.Billing.Entities
{
    public class PaymentMode
    {
        public int PaymentModeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public PaymentHistory PaymentHistory { get; set; } = new PaymentHistory();
    }
}