using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car1 = new Auto("Ford", 400, 300000);
            Auto car2 = new Auto("Mazda");
            Auto car3 = new Auto();          
            car1.display();
            car2.display();
            car3.display();

            Auto[] cars = new Auto[3];
            for (int i = 0; i < 3; i++)
                cars[i] = new Auto("Car" + (i + 1).ToString());

            for (int i = 0; i < 3; i++)
                cars[i].display();
        }
    }

}
