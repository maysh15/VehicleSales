using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VehicleSales.Logic.Interfaces;
using VehicleSales.Model;

namespace VehicleSales.Logic
{
    public class VehicleDealExlFileUploader : IVehicleDealFileUploader
    {
        public List<VehicleDeal> LoadVehicleDealFile(IFormFile formFile)
        {
            var lstVehicleDeal = new List<VehicleDeal>();
            //Implementation for Excel file upload
            return lstVehicleDeal;
        }

        public bool ValidateVehicleDealFile(IFormFile formFile)
        {
            //Implementation for Validate Excel file data
            return true;
        }
    }
}
