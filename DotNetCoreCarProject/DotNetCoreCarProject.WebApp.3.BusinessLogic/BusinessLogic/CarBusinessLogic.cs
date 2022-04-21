using DotNetCoreCarProject.Common.Models;
using DotNetCoreCarProject.WebApp._3.BusinessLogic.IBusinessLogic;
using DotNetCoreCarProject.WebApp._4.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCarProject.WebApp._3.BusinessLogic.BusinessLogic
{
    public class CarBusinessLogic : ICarBusinessLogic
    {

        private readonly ICarRepository iCarRepository;

        public CarBusinessLogic(ICarRepository _iCarRepository)
        {
            iCarRepository = _iCarRepository;
        }


        public async Task<List<Car>> SearchCarAsync(CarSearchingParameters carSearchingParameters)
        {
            return await iCarRepository.SearchCarAsync(carSearchingParameters);
        }

        public async Task<bool> SaveCarAsync(Car car)
        {
            return await iCarRepository.SaveCarAsync(car);
        }

        public async Task<bool> DeleteCarAsync(int id)
        {
            return await iCarRepository.DeleteCarAsync(id);
        }

        public async Task<bool> UpdateCarAsync(Car car, int id)
        {
            return await iCarRepository.UpdateCarAsync(car, id);
        }
    }
}
