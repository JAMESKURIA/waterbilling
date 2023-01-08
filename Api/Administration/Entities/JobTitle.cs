namespace WaterBilling.Api.Administration.Entities
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string JobName { get; set; } = string.Empty;
        public Employee Employee { get; set; } = new Employee();
    }
}