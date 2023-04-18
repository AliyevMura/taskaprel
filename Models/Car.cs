using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17april.Models
{
   internal class Car
    {

        // public static int Id;
        // public string Name;
        // public string Color;
        // public int Speed;
        // public int count;


        //public Car() {


        //     Id++;
        //     count++;

        // }
        





        public int Id;
        public static int count;
        public string Name { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public Car()
        {
            count++;
            Id = count;
        }
        public Car(string name, string color, int speed)
        {
            count++;
            Id = count;
            Name = name;
            Color = color;
            Speed = speed;

        }

    }
}
