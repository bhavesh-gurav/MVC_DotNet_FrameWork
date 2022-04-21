using DotNetCoreCarProject.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCarProject.WebApp._3.BusinessLogic.IBusinessLogic
{
    public interface ICarBusinessLogic
    {
        Task<List<Car>> SearchCarAsync(CarSearchingParameters carSearchingParameters);
        Task<bool> SaveCarAsync(Car car);
        Task<bool> DeleteCarAsync(int id);
        Task<bool> UpdateCarAsync(Car car, int id);
    }
}
