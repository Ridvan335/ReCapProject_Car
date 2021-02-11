using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=200,Description="200hp",ModelYear=1998},
                new Car{Id=2,BrandId=3,ColorId=5,DailyPrice=100,Description="150hp",ModelYear=2005},
                new Car{Id=3,BrandId=1,ColorId=1,DailyPrice=150,Description="125hp",ModelYear=2006},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=125,Description="95hp",ModelYear=2015},
                new Car{Id=5,BrandId=3,ColorId=4,DailyPrice=175,Description="225hp",ModelYear=2020},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int ıd)
        {
            return _cars.Where(c => c.BrandId == ıd).ToList();
        }

        
    }
}
