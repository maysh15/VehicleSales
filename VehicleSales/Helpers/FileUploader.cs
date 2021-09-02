using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleSales.Logic.Interfaces;
using VehicleSales.Model;

namespace VehicleSales.Helpers
{
    //FileUploader has single resposibility for handling file upload
    public class FileUploader
    {
        private readonly IVehicleDealFileUploader _vehicleDealFileUploader;

        public FileUploader(IVehicleDealFileUploader vehicleDealFileUploader)
        {
            _vehicleDealFileUploader = vehicleDealFileUploader;
        }
        public List<VehicleDeal> LoadVehicleDeal(IFormFile formFile)
        {
            var lstVehicleDeal = this._vehicleDealFileUploader.LoadVehicleDealFile(formFile);
            return lstVehicleDeal;
        }
    }
}
