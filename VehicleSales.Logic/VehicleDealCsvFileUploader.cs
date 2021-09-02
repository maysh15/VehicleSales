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
    // Interface Segregation
    // If VehicleDealCsvFileUploader only needs to store the file other fileuploaders do not need to implement the interface method
    // SaveVehicleDealFile is in IVehicleDealFileStore instead of IVehicleDealFileUploader
    public class VehicleDealCsvFileUploader : IVehicleDealFileUploader, IVehicleDealFileStore
    {
        public List<VehicleDeal> LoadVehicleDealFile(IFormFile formFile)
        {
            var lstVehicleDeal = new List<VehicleDeal>();
            var result = new StringBuilder();
            var encoding = Encoding.GetEncoding("iso-8859-1");
            using (var reader = new StreamReader(formFile.OpenReadStream(), encoding, false))
            {
                var lineNumber = 1;
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();
                    if (lineNumber > 1)
                    {
                        var lineRst = Formatter.RemoveCurrencyFormatting(line);
                        var objArr = lineRst.Split(',');
                        var obj = new VehicleDeal();
                        obj.DealNumber = objArr[0];
                        obj.CustomerName = objArr[1];
                        obj.DealershipName = objArr[2];
                        obj.Vehicle = objArr[3];
                        obj.Price = Convert.ToDecimal(objArr[4]);
                        obj.Date = Convert.ToDateTime(objArr[5]);
                        lstVehicleDeal.Add(obj);
                        result.AppendLine(line);
                    }
                    lineNumber++;
                }
            }
            return lstVehicleDeal;
        }

        public bool ValidateVehicleDealFile(IFormFile formFile)
        {
            var isValid = false;
            //File data can be validated here its not empty and correct format
            isValid = true;
            return isValid;
        }

        public bool SaveVehicleDealFile(IFormFile formFile)
        {
            var sucessfullySaved = false;

            return sucessfullySaved;
        }
    }
}
