using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCar());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "Günlük fiyat= " + car.DailyPrice);
            }
           
        }
    }
}