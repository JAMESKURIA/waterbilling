using System.Collections.ObjectModel;
using WaterBilling.Api.CustomerSupport.Entities;
using WaterBilling.Api.WaterUsage.Entities;

namespace WaterBilling.Api.Infrastructure.Entities
{
    public class Zone
    {
        public int ZoneId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string AreaCode { get; set; } = string.Empty;
        public ICollection<Meter> Meters { get; set; } = new Collection<Meter>();
        public MeterReader MeterReader { get; set; } = new MeterReader();
    }
}