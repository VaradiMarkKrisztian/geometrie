using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie_curs2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string name1 = Console.ReadLine();
                int points1 = Convert.ToInt32(Console.ReadLine());
                string name2 = Console.ReadLine();
                int points2 = Convert.ToInt32(Console.ReadLine());

                DancerPoints dancer1 = new DancerPoints(name1, points1);
                DancerPoints dancer2 = new DancerPoints(name2, points2);

                DancerPoints total = dancer1 + dancer2;
                Console.WriteLine(total.name);
                Console.WriteLine(total.points);
            Console.ReadKey();
        }

        class DancerPoints
        {
            public string name;
            public int points;
            public DancerPoints(string name, int points)
            {
                this.name = name;
                this.points = points;
            }

            //overload the + operator
            public static DancerPoints operator+(DancerPoints a, DancerPoints b)
            {
                string name = a.name + b.name;
                int points = a.points + b.points;
                DancerPoints total = new DancerPoints(name, points);
                return total;
            }
        }
        
            //ex1();
            //ex2();
           // ex3();
    

        private static void ex3()
        {
            Console.WriteLine("introduceti coordonate pentru vector1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti coordonate pentru vector2");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti coordonate pentru vector3");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int z3 = int.Parse(Console.ReadLine());
            Console.WriteLine("v1= ");
            if (y1 >= 0 && z1 > 0) Console.WriteLine($"{x1}i+{y1}j+{z1}k");
            if (y1 < 0 && z1 > 0) Console.WriteLine($"{x1}i{y1}j+{z1}k");
            if (y1 >= 0 && z1 < 0) Console.WriteLine($"{x1}i+{y1}j{z1}k");
            if (y1 < 0 && z1 < 0) Console.WriteLine($"{x1}i{y1}j{z1}k");
            if (y1 >= 0 && z1 == 0) Console.WriteLine($"{x1}i+{y1}j");
            if (y1 < 0 && z1 == 0) Console.WriteLine($"{x1}i{y1}j");
            Console.WriteLine("v2= ");
            if (y2 >= 0 && z2 > 0) Console.WriteLine($"{x2}i+{y2}j+{z2}k");
            if (y2 < 0 && z2 > 0) Console.WriteLine($"{x2}i{y2}j+{z2}k");
            if (y2 >= 0 && z2 < 0) Console.WriteLine($"{x2}i+{y2}j{z2}k");
            if (y2 < 0 && z2 < 0) Console.WriteLine($"{x2}i{y2}j{z2}k");
            if (y2 >= 0 && z2 == 0) Console.WriteLine($"{x2}i+{y2}j");
            if (y2 < 0 && z2 == 0) Console.WriteLine($"{x2}i{y2}j");
            Console.WriteLine("v2= ");
            if (y3 >= 0 && z3 > 0) Console.WriteLine($"{x3}i+{y3}j+{z3}k");
            if (y3 < 0 && z3 > 0) Console.WriteLine($"{x3}i{y3}j+{z3}k");
            if (y3 >= 0 && z3 < 0) Console.WriteLine($"{x3}i+{y3}j{z3}k");
            if (y3 < 0 && z3 < 0) Console.WriteLine($"{x3}i{y3}j{z3}k");
            if (y3 >= 0 && z3 == 0) Console.WriteLine($"{x3}i+{y3}j");
            if (y3 < 0 && z3 == 0) Console.WriteLine($"{x3}i{y3}j");
            Console.WriteLine( "Produs mixt: ");
            double produsmixt = x1 * y2 * z3 + x2 * y3 * z1 + x3 * y1 * z2 - x3 * y2 * z1 - y3 * z2 * x1 - z3 * x2 * y1;
            Console.WriteLine(produsmixt);
            Console.WriteLine("Verificare Coplanaritate");
            if (produsmixt == 0) Console.WriteLine("Este coplanar");
            else Console.WriteLine("Nu este coplanar");
            Console.WriteLine("Volum paralelogram");
            Console.WriteLine(Math.Abs(produsmixt));
            Console.ReadKey();
        }

        private static void ex2()
        {
            Console.WriteLine("introduceti coordonate pentru vector1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti coordonate pentru vector2");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A)afisare");
            Console.WriteLine("v1= ");
            if (y1 >= 0 && z1 >= 0) Console.WriteLine($"{x1}i+{y1}j+{z1}k");
            if (y1 < 0 && z1 >= 0) Console.WriteLine($"{x1}i{y1}j+{z1}k");
            if (y1 >= 0 && z1 < 0) Console.WriteLine($"{x1}i+{y1}j{z1}k");
            if (y1 < 0 && z1 < 0) Console.WriteLine($"{x1}i{y1}j{z1}k");
            Console.WriteLine("v2= ");
            if (y2 >= 0 && z2 >= 0) Console.WriteLine($"{x2}i+{y2}j+{z2}k");
            if (y2 < 0 && z2 >= 0) Console.WriteLine($"{x2}i{y2}j+{z2}k");
            if (y2 >= 0 && z2 < 0) Console.WriteLine($"{x2}i+{y2}j{z2}k");
            if (y2 < 0 && z2 < 0) Console.WriteLine($"{x2}i{y2}j{z2}k");
            Console.WriteLine("A)Produs vectorial= ");
            double a = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
            double b = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
            double c = x1 * x2 + y1 * y2 + z1 * z2;
            int A1 = y1 * z2 - y2 * z1;
            int A2 = x1 * z2 - x2 * z1;
            int A3 = x1 * y2 - x2*y1;
            if(A2 >= 0 && A3 >= 0) Console.WriteLine($"{A1}i-{A2}j+{A3}k");
            if (A2 < 0 && A3 >= 0) Console.WriteLine($"{A1}i{A2}j+{A3}k");
            if (A2 >= 0 && A3 < 0) Console.WriteLine($"{A1}i-{A2}j{A3}k");
            if (A2< 0 && A3 < 0) Console.WriteLine($"{A1}i{A2}j{A3}k");
            
            Console.WriteLine();
            Console.WriteLine("B)coliniaritate");
            if (A1 - A2 - A3 == 0) Console.WriteLine("Este coliniar");
            else Console.WriteLine("Nu este coliniar");
            Console.WriteLine("C)Aria paralelogram");
            double arie = Math.Sqrt(A1*A1+A2*A2+A3*A3);
            Console.WriteLine(arie);
            Console.ReadKey();
        }

        private static void ex1()
        {
            Console.WriteLine("introduceti coordonate pentru vector1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti coordonate pentru vector2");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A)afisare");
            Console.WriteLine("v1= ");
            if (y1 >= 0 && z1 >= 0) Console.Write($"{x1}i+{y1}j+{z1}k=");
            if (y1 < 0 && z1 >= 0) Console.Write($"{x1}i{y1}j+{z1}k");
            if (y1 >= 0 && z1 < 0) Console.Write($"{x1}i+{y1}j{z1}k");
            if (y1 < 0 && z1 < 0) Console.Write($"{x1}i{y1}j{z1}k");
            Console.WriteLine("v2= ");
            if (y2 >= 0 && z2 >= 0) Console.Write($"{x2}i+{y2}j+{z2}k");
            if (y2 < 0 && z2 >= 0) Console.Write($"{x2}i{y2}j+{z2}k");
            if (y2 >= 0 && z2 < 0) Console.Write($"{x2}i+{y2}j{z2}k");
            if (y2 < 0 && z2 < 0) Console.Write($"{x2}i{y2}j{z2}k");
            Console.WriteLine("B)produs scalar");
            Console.WriteLine($"v1*v2= {x1*x2+y1*y2+z1*z2}");
            if (x1 * x2 + y1 * y2 + z1 * z2 == 0) Console.WriteLine(" este perpendicular");
            else Console.WriteLine("Nu este perpendicular");
            Console.WriteLine("C)marimea vectorului");
            Console.WriteLine($"marimea vectorului v1=");
            double v1 = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
            Console.Write(v1);
            Console.WriteLine($"marimea vectorului v2=");
            double v2 = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
            Console.Write(v2);
            Console.ReadKey();
        }
    }
}

