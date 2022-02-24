using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLab9
{
    abstract class Creator
    {
        public string name;
        public abstract IProduct Create();

        public void CheckCar()
        {
            var obj = Create();
            Console.WriteLine("The car is fine");
            Console.WriteLine("");
        }

    }

}
