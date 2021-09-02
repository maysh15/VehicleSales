using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleSales.Model;

namespace VehicleSales.Logic.Interfaces
{
    public interface IVehicleDealFileUploader
    {
        List<VehicleDeal> LoadVehicleDealFile(IFormFile formFile);
    }
}
