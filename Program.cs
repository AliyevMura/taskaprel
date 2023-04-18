using Task17april.Models;

namespace Task17april
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Person.Name = "Test";
            //Console.WriteLine(Person.Name);
            //Person person = new Person();
            //Console.WriteLine(person.Id);
            //Console.WriteLine(Person.count);
            //Person person1 = new Person();
            //Console.WriteLine(Person.count);
            //Console.WriteLine(person1.Id);
            //Person person2 = new Person();
            //Console.WriteLine(Person.count);
            //Console.WriteLine(person2.Id);

           


            Car car1 = new Car("BMW", "Red", 170);
            Car car2 = new Car("Mercedec", "Blue", 100);
            Car car3 = new Car("Vaz", "White", 20);

            Galery galery = new Galery();

            galery.AddCar(car1);
            galery.AddCar(car2);
            galery.AddCar(car3);
            
            galery.ShowAllCars();

        }


        
    }
}