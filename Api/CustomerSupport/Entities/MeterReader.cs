using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WaterBilling.Api.Infrastructure.Entities;

namespace WaterBilling.Api.CustomerSupport.Entities
{
    public class MeterReader
    {
        [Key]
        public int MeterReaderId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public int ZoneId { get; set; }
        public virtual Zone Zone { get; set; } = new Zone();
    }
}