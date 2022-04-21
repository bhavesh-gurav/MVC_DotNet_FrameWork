using DotNetCoreCarProject.Common.Enums;

namespace DotNetCoreCarProject.Common.Models
{
    public class Car
    {
        public int? Id { get; set; }
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public string? CarManufacturer { get; set; }
        public Colors? CarColor { get; set; }
        public string? CarReleaseDate { get; set; }

    }
}