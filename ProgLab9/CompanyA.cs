using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLab9
{
    class CompanyA : Creator
    {
        public CompanyA(string n)
        {
            name = n;
        }

        public override IProduct Create()
        {
            return new BigCar();
        }

    }
}
