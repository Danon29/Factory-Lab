using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLab9
{
    class CompanyB : Creator
    {
        public CompanyB(string n)
        {
            name = n;
        }

        public override IProduct Create()
        {
            return new SmallCar();
        }

    }
}
