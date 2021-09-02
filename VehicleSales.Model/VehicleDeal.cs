using System;

namespace VehicleSales.Model
{
    public class VehicleDeal
    {
        public string DealNumber { get; set; }
        public string CustomerName { get; set; }
        public string DealershipName { get; set; }
        public string Vehicle { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

    }
}
