using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Files
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
        }
        public Car(string make, string model, string colour, decimal price)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Price = price;
        }
    }

 
}
