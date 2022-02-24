using System;

namespace ProgLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            var Audi = new CompanyB("Audi");
            var BMW = new CompanyA("BMW");
            var control = new Controler();
            control.NewBig(Audi);
            control.NewSmall(BMW);
        }
    }
}
