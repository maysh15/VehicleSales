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
    public class VehicleDealCsvFileUploader : IVehicleDealFileUploader
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
                        var regex = new Regex("\\\"(.*?)\\\"");
                        var line1 = regex.Replace(line, m => m.Value.Replace(",", ""));
                        var line2 = line1.Replace("\"", "");
                        var objArr = line2.Split(',');
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
    }
}
