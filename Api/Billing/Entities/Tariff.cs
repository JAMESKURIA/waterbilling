using WaterBilling.Api.Customers.Entities;

namespace WaterBilling.Api.Billing.Entities
{
    public class Tariff
    {
        public int TariffId { get; set; }
        public string TariffName { get; set; } = string.Empty; // e.g. Residential Water Tariff | Commercial Water Tariff
        public string TariffDesc { get; set; } = string.Empty;
        public String RatePerUnit { get; set; } = string.Empty;
        public String FixedCharge { get; set; } = string.Empty;
        public AccountType AccountType { get; set; } = new AccountType();
        public ICollection<Bill> Bills { get; set; } = new Collection<Bill>();
    }
}