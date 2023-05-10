using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClass
{
    public class car
    {
        public string brand;
        public string color;
        public string LicensePlate;

        public void keyon()
        {
            Console.WriteLine("ketika mobil {0} berwarna {1} dengan plat nomor {2} hidup, mengeluarkan suara yang sangat bising", brand, color, LicensePlate);
        }
        public void keyof()
        {
            Console.WriteLine("keika mobil {0} berwarna {1} dengan plat nomor {2} mati maka klakson tidak dapat berbunyi", brand, color, LicensePlate);
        }
        public void mengklakson()
        {
            Console.WriteLine("mobil {0} berwarna {1} dengan plat nomor {2} memiliki suara klakson yang nyaring",brand, color, LicensePlate);
        }

    static void Main(string[] args)
        {
            car car1 = new car();
            Console.WriteLine("===MASUKAN BRAND MOBIL===");
            car1.brand = Console.ReadLine();
            Console.WriteLine("===MASUKAN WARNA MOBIL===");
            car1.color = Console.ReadLine();
            Console.WriteLine("===MASUKAN PLAT NOMOR MOBIL===");
            car1.LicensePlate = Console.ReadLine();

            car1.keyon();
            car1.keyof();
            car1.mengklakson();
            Console.ReadKey(true);
        }
    }
}
