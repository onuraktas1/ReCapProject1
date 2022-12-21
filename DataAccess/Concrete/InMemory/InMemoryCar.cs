using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCar : ICarDal
    {
        List<Car> _cars;

        public InMemoryCar()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=2, ColorId=3, DailyPrice=350, Description="Volkwagen Golf 2.0 TDI", ModelYear=2015},
                new Car{CarId=2, BrandId=1, ColorId=3, DailyPrice=700, Description="Audi RS6", ModelYear=2021},
                new Car{CarId=3, BrandId=1, ColorId=3, DailyPrice=400, Description="Volkwagen Passat ", ModelYear=2018},
                new Car{CarId=4, BrandId=3, ColorId=3, DailyPrice=500, Description="Mercedes E200", ModelYear=2020},
                new Car{CarId=5, BrandId=4, ColorId=3, DailyPrice=650, Description="Volvo XC90", ModelYear=2022},
                new Car{CarId=6, BrandId=2, ColorId=3, DailyPrice=700, Description="BMW M5", ModelYear=2019},

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var CarToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();

        }

        public void Update(Car car)
        {
            var CarToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ColorId = car.ColorId;
        }
    }
}
