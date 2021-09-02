using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleSales.Model;

namespace VehicleSales.Logic.Interfaces
{
    public interface IVehicleDealFileUploader
    {
        bool ValidateVehicleDealFile(IFormFile formFile);
        List<VehicleDeal> LoadVehicleDealFile(IFormFile formFile);
    }
}
