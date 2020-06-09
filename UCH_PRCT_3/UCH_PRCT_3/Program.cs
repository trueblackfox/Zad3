using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace UCH_PRCT_3

{

    class Program

    {

        static void Main(string[] args)

        {

            double x, y;

            bool ok = false;

            Console.WriteLine("Введите x");

            do

            {

                string buf = Console.ReadLine();// строка-буфер

                ok = Double.TryParse(buf, out x);

                if (!ok) Console.WriteLine("Ошибка, введите целое значение x!");

            } while (!ok);

            Console.WriteLine("Введите y");

            do

            {

                string buf = Console.ReadLine();// строка-буфер

                ok = Double.TryParse(buf, out y);

                if (!ok) Console.WriteLine("Ошибка, введите целое значение y!");

            } while (!ok);

            bool res1 = (x >= 0 && y >= 0 && y <= (-3 * x + 2));

            bool res2 = (x <= 0 && y >= 0 && y <= (3 * x + 2));

            bool res3 = (x <= 0 && y <= 0 && y >= -1 && y <= (3 * x + 2));

            bool res4 = (x >= 0 && y <= 0 && y >= -1 && y <= (-3 * x + 2));

            if ((res1 || res2 || res3 || res4) == true) Console.WriteLine("Точка принадлежит плоскости");

            else

            {

                Console.WriteLine("Точка не принадлежит плоскости");

            }

            Console.ReadLine();

        }

    }

}