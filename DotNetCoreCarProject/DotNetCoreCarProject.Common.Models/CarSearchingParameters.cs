using DotNetCoreCarProject.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCarProject.Common.Models
{
    public class CarSearchingParameters
    {
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public string? CarManufacturer { get; set; }
        public Colors CarColor { get; set; }
        public string? CarReleaseDate { get; set; }
    }
}
