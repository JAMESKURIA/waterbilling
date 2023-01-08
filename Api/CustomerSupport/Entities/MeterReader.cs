using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WaterBilling.Api.Administration.Entities;
using WaterBilling.Api.Infrastructure.Entities;

namespace WaterBilling.Api.CustomerSupport.Entities
{
    public class MeterReader
    {
        [Key]
        public int MeterReaderId { get; set; }
        public int ZoneId { get; set; }
        public virtual Zone Zone { get; set; } = new Zone();
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();
    }
}