using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Rozw_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj datę i czas w formacie: Thu 16 Nov 8:30 AM 2017");
            string format = "ddd dd MMM h:mm tt yyyy";
            string wejscie = Console.ReadLine();
            DateTime data;

            if (DateTime.TryParseExact(wejscie, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                Console.WriteLine(data.ToString());
            }
            else
            {
                Console.WriteLine("błędna data");
            }

            Console.ReadKey();

        }
    }
}
