using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the object
            Donut dougDonut = new Donut();
            Donut steveDonut = new Donut();
            Donut brookeDonut = new Donut();

            //setting property values
            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "small";
            dougDonut.IsSpecial = true;

            steveDonut.Filling = "none";
            steveDonut.Price = 2;
            steveDonut.Type = "small";
            steveDonut.IsSpecial = false;

            brookeDonut.Filling = "chocolate";
            brookeDonut.Price = 3;
            brookeDonut.Type = "normal";
            brookeDonut.IsSpecial = true;

            Console.WriteLine(brookeDonut.Filling)
        }
    }
}
