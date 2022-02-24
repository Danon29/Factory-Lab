using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLab9
{

    class Controler
    {
        public void NewBig(Creator par)
        {
            Console.WriteLine($"{par.name} создала объект большой машины");
            par.CheckCar();
        }

        public void NewSmall(Creator par)
        {
            Console.WriteLine($"{par.name} создала объект маленькой машины");
            par.CheckCar();
        }
    }

}

