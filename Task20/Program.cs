using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {

        delegate double CalcDelegate(double input);


        static void Main(string[] args)
        {
            double R = 4.4;

            CalcDelegate LenCircle = (inputR) =>
            {
                return inputR * 2 * Math.PI;
            };

            CalcDelegate SqrCircle = (inputR) =>
            {
                return inputR * inputR * Math.PI;
            };

            CalcDelegate VolumeBall = (inputR) =>
            {
                return 4 / 3 * Math.PI * Math.Pow(inputR, 3);
            };

            Console.WriteLine("Длина окружности {0:f2}", LenCircle(R));

            Console.WriteLine("площадь круга {0:f2}", SqrCircle(R));

            Console.WriteLine("объем шара {0:f2}", VolumeBall(R));


            CalcDelegate calcer = LenCircle;
            Console.WriteLine("Длина окружности {0:f2}", calcer(R));
            calcer = SqrCircle;
            Console.WriteLine("площадь круг {0:f2}", calcer(R));
            calcer = VolumeBall;
            Console.WriteLine("объем шара {0:f2}", calcer(R));
            Console.ReadKey();
        }

        static double LenCircle(double inputR)
        {
            return inputR * 2 * Math.PI;
        }
        static double SqrCircle(double inputR)
        {

            return inputR * inputR * Math.PI;
        }

        static double VolumeBall(double inputR)
        {

            return 4 / 3 * Math.PI * Math.Pow(inputR, 3);
        }

    }
}
