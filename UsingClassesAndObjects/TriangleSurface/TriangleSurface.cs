// 4.Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

namespace TriangleSurface
{
    using System;
    using System.Linq;

    internal class TriangleSurface
    {
        private static void Main()
        {
            Console.WriteLine("You can choose one of the following options: ");
            Console.WriteLine("1 -> Side and altitude to it;");
            Console.WriteLine("2 -> Three sides;");
            Console.WriteLine("3 -> Two sides and an angle between them;");
            Console.WriteLine("0 -> Exit");

            Console.Write("Please make your choice: ");
            int choose = int.Parse(Console.ReadLine());

            Menu(choose);
        }

        private static void Menu(int choose)
        {
            switch (choose)
            {
                case 1:
                    SideAndAltitude();
                    break;
                case 2:
                    ThreeSides();
                    break;
                case 3:
                    TwoSideAndAngle();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        private static void TwoSideAndAngle()
        {
            Console.Write("Please enter one side: ");
            double firstSide = double.Parse(Console.ReadLine());

            Console.Write("Please enter another side: ");
            double secondSide = double.Parse(Console.ReadLine());

            Console.Write("Please enter an angle between sides: ");
            int angle = int.Parse(Console.ReadLine());

            double angleInRadians = 0.0;
            angleInRadians = Math.PI * angle / 180.0;

            double surface = 0.0;
            surface = 0.5 * firstSide * secondSide * Math.Sin(angleInRadians);

            Console.WriteLine("S = 0.5*{0}*{1}*sin({2}) = {3}", firstSide, secondSide, angle, surface);
        }

        private static void ThreeSides()
        {
            Console.Write("Please enter first side: ");
            double firstSide = double.Parse(Console.ReadLine());

            Console.Write("Please enter second side: ");
            double secondSide = double.Parse(Console.ReadLine());

            Console.Write("Please enter third side: ");
            double thirdSide = double.Parse(Console.ReadLine());

            double halfPerimetar = 0.0;
            halfPerimetar = 0.5 * (firstSide + secondSide + thirdSide);

            double surface = 0.0;
            surface = Math.Sqrt(halfPerimetar * (halfPerimetar - firstSide) * (halfPerimetar - secondSide) * (halfPerimetar - thirdSide));

            Console.WriteLine("S = {0}", surface);
        }

        private static void SideAndAltitude()
        {
            Console.Write("Please enter a side: ");
            double side = double.Parse(Console.ReadLine());

            Console.Write("Please enter the altitude to the side: ");
            double altitude = double.Parse(Console.ReadLine());

            double surface = 0.0;

            surface = 0.5 * side * altitude;

            Console.WriteLine("S = 0.5*{0}*{1} = {2}", side, altitude, surface);
        }
    }
}