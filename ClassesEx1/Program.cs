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



            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);

        }

           
    }



}