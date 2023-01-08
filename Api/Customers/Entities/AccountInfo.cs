namespace WaterBilling.Api.Customers.Entities
{
    public class AccountInfo
    {
        public int AccountInfoId { get; set; }
        public string PropertySize { get; set; } = string.Empty;
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; } = new AccountType();
        public Customer Customer { get; set; } = new Customer();

    }
}