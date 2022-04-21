using DotNetCoreCarProject.Common.Enums;
using DotNetCoreCarProject.Common.Models;
using DotNetCoreCarProject.WebApp._4.DataAccess.Entities;
using DotNetCoreCarProject.WebApp._4.DataAccess.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCarProject.WebApp._4.DataAccess.Repository
{
    public class CarRepository : BaseRepository, ICarRepository
    {
        public CarRepository(Context context) : base(context)
        {
        }


        public async Task<List<Car>> SearchCarAsync(CarSearchingParameters carSearchingParameters)
        {
            IQueryable<CarEntity>? CarQuery = (IQueryable<CarEntity>)context.CarDbSet.OrderBy(c => c.CarName);
            //IQueryable<CarEntity>? CarQuery = (IQueryable<CarEntity>?)context.CarDbSet.AsQueryable();

            return await CarQuery.Select(c => new Car
            {
                Id = c.Id,
                CarName = c.CarName,
                CarModel = c.CarModel,
                CarManufacturer = c.CarManufacturer,
                CarColor = (Colors?)(short?)c.CarColor,
                CarReleaseDate = c.CarReleaseDate
            }).ToListAsync();
        }

        public async Task<bool> SaveCarAsync(Car car)
        {
            var CarObj = context.CarDbSet.Find(car.Id);
            if (CarObj == null)
            {
                CarObj = new CarEntity();
                context.Add(CarObj);
            }
            CarObj.CarColor = (short)car.CarColor;
            CarObj.CarName = car.CarName;
            CarObj.CarModel = car.CarModel;
            CarObj.CarManufacturer = car.CarManufacturer;
            CarObj.CarReleaseDate = car.CarReleaseDate;

            return await context.SaveChangesAsync() > 0;

        }

        //Delete API
        public async Task<bool> DeleteCarAsync(int id)
        {

           // var ObjCar = context.CarDbSet.First(c => c.Id == id);

            CarEntity ObjCar = new CarEntity() { Id = id };
            //context.Attach(ObjCar);
            context.Remove(ObjCar);

            return await context.SaveChangesAsync() > 0;

            //var ObjCar = context.CarDbSet.Find(id);
            ////Car ObjCar = new Car() { Id = id };

            //if (ObjCar == null)
            //{
            //    ObjCar = new CarEntity();
            //    //context.Add(ObjCar);
            //    context.Attach(ObjCar);
            //    context.Remove(ObjCar);
            //}
            //return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateCarAsync(Car car, int id)
        {
            //var carObj = await context.CarDbSet.FindAsync(car.Id);
            ////var carObj = await context.CarDbSet.FindAsync(id);
            //if (carObj != null)
            //{
            //    carObj.CarColor = (short)car.CarColor;
            //    carObj.CarName = car.CarName;
            //    carObj.CarModel = car.CarModel;
            //    carObj.CarManufacturer = car.CarManufacturer;
            //    carObj.CarReleaseDate = car.CarReleaseDate;
            //}
            //return await context.SaveChangesAsync() > 0;

            var carObj = new CarEntity()
            {
                Id = id,
                CarColor = (short?)car.CarColor,
                CarName = car.CarName,
                CarModel = car.CarModel,
                CarManufacturer = car.CarManufacturer,
                CarReleaseDate = car.CarReleaseDate
            };
            //context.CarDbSet.Update(carObj);
            context.Update(carObj);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
