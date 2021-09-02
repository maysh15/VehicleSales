using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using VehicleSales.Model;

namespace VehicleSales.Logic
{
    public static class VehicleDealFilter
    {
        public static string MostSoldVehicle(List<VehicleDeal> lstVehicleDeal)
        {
            var results = from p in lstVehicleDeal
                          group p.DealNumber by p.Vehicle into g
                          select new { Vehicle = g.Key, DealsCount = g.Count() };

            var list = results.OrderByDescending(g => g.DealsCount).First();

            var mostSoldVehicle = list.Vehicle;

            return mostSoldVehicle;
        }
    }
}
