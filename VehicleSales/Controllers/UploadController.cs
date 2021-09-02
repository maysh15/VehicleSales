using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleSales.Helpers;
using VehicleSales.Logic;
using VehicleSales.Logic.Interfaces;
using VehicleSales.Model;

namespace VehicleSales.Controllers
{
    [Route("[controller]")]
    public class FileUploadController : Controller
    {
        private readonly IVehicleDealFileUploader _fileUploader;

        public FileUploadController()
        {
            _fileUploader = new VehicleDealCsvFileUploader();
        }

        [HttpPost("Upload")]
        public IActionResult Upload()
        {
            try
            {
                var formFile = HttpContext.Request.Form.Files.GetFile("file");

                var vehicleMostSoldResult = new VehicleMostSoldResult();
                //Dependency Injection
                var uploader = new FileUploader(_fileUploader);
                var lstVehicleDeal = uploader.LoadVehicleDeal(formFile);

                //var results = from p in lstVehicleDeal
                //              group p.DealNumber by p.Vehicle into g
                //              select new { Vehicle = g.Key, DealsCount = g.Count() };

                //var list = results.OrderByDescending(g => g.DealsCount).First();
                vehicleMostSoldResult.lstVehicleDeal = lstVehicleDeal;
                vehicleMostSoldResult.mostSoldVehicle = VehicleDealFilter.MostSoldVehicle(lstVehicleDeal);
                return Ok(vehicleMostSoldResult);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
