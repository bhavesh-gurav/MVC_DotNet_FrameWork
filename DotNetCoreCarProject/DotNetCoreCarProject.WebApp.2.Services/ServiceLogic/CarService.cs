using DotNetCoreCarProject.Common.Models;
using DotNetCoreCarProject.WebApp._2.Services.IServices;
using DotNetCoreCarProject.WebApp._3.BusinessLogic.IBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCarProject.WebApp._2.Services.ServiceLogic
{
    public class CarService : ICar
    {
        private readonly ICarBusinessLogic carBusinessLogic;

        public CarService(ICarBusinessLogic iCarBusinessLogic)
        {
            carBusinessLogic = iCarBusinessLogic;
        }


        public async Task<List<Car>> SearchCarAsync(CarSearchingParameters carSearchingParameters)
        {
            return await carBusinessLogic.SearchCarAsync(carSearchingParameters);
        }

        
        public async Task<bool> SaveCarAsync(Car car)
        {
            return await carBusinessLogic.SaveCarAsync(car);
        }

        public async Task<bool> DeleteCarAsync(int id)
        {
            return await carBusinessLogic.DeleteCarAsync(id);
        }

        public async Task<bool> UpdateCarAsync(Car car,int id)
        {
            return await carBusinessLogic.UpdateCarAsync(car, id);
        }
    }
}
