using WaterBilling.Api.Billing.Entities;

namespace WaterBilling.Api.Customers.Entities
{
    public class AccountType
    {
        public int AccountTypeId { get; set; }
        public string Name { get; set; } = string.Empty; // residential | commercial | industrial
        public string ShortDesc { get; set; } = string.Empty;
        public int TariffId { get; set; }
        public Tariff Tariff { get; set; } = new Tariff();
        public AccountInfo AccountInfo { get; set; } = new AccountInfo();

    }
}