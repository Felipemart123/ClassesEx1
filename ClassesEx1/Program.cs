using System;
using System.Collections.Generic;

namespace ClassesEx1
{

    class program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "KIA";
            myCar.Model = "Optima";
            myCar.Year = 2019;

            var ford = new Car()
            {
                Make = "Ford",
                Model = "Explorer",
                Year = 2001
            };
        }
           
    }



}