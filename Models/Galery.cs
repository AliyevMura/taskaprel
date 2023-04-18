using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17april.Models
{
    internal class Galery
    {

        public Car[] cars = new Car[0];
        public int Id;
        public Galery()
        {

        }
        public Galery(int id)
        {
            Id = id;
        }
        public void AddCar(Car car)
        {
//burani yaza bilmedim
        }
        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Name);
                Console.WriteLine(car.Color);
                Console.WriteLine(car.Speed);
                
            }
        }
        public Car[] GetAllCars()
        {
            
            return cars;
        }
        public void FindById()
        {
            foreach (var car in cars)
            {
                if (this.Id == car.Id)
                {
                    Console.WriteLine(car.Name);
                }
            }
        }
       

    }
}
