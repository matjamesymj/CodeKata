using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Files
{
    public class ReadCsv
    {
        public List<Car> ReadCsvFile()
        {
            var streamReader = new StreamReader("C:\\Users\\Mathew\\Source\\Repos\\CodeKatas\\CodeKatas\\Files\\test.csv");
            var cars = new List<Car>();

            while (!streamReader.EndOfStream)
            {

                var line = streamReader.ReadLine();
                if (line != null)
                {
                    var values = line.Split('\t');
                    var car = new Car(values[0],values[1],values[2],Convert.ToDecimal(values[3]));
                    cars.Add(car);
                }
            }

           
            return cars;
        }
    }
}
