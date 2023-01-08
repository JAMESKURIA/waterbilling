using WaterBilling.Api.CustomerSupport.Entities;

namespace WaterBilling.Api.Administration.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Msisdn { get; set; } = string.Empty;
        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; } = new JobTitle();
        public MeterReader MeterReader { get; set; } = new MeterReader();
    }
}