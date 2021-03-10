using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie_curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("doubleroduceti coordonate");
            Console.WriteLine("Xa=");
            double Xa = double.Parse(Console.ReadLine());
            Console.WriteLine("Ya=");
            double Ya = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Za=");
            double Za = double.Parse(Console.ReadLine());
            Console.WriteLine("Xb=");
            double Xb = double.Parse(Console.ReadLine());
            Console.WriteLine("Yb=");
            double Yb = double.Parse(Console.ReadLine());
            Console.WriteLine("Zb=");
            double Zb = double.Parse(Console.ReadLine());
            Console.WriteLine("Xc=");
            double Xc = double.Parse(Console.ReadLine());
            Console.WriteLine("Yc=");
            double Yc = double.Parse(Console.ReadLine());
            Console.WriteLine("Zc=");
            double Zc = double.Parse(Console.ReadLine());
            ecDreapta(Xa,Xb,Yb,Ya);
            ecDistanta(Xa, Xb, Yb, Ya);
            Coliniar(Xa, Xb, Yb, Ya, Xc, Yc);
            Concurente(Xa, Xb, Yb, Ya, Xc, Yc,Za,Zb,Zc);
           
            

        }

        private static void Concurente(double xa, double xb, double yb, double ya, double xc, double yc, double za, double zb, double zc)
        {
            if ( ya >= 0 && za >= 0) Console.WriteLine($"d1={xa}x+{ya}y+{za}=0");
            else if ( ya < 0 && za >= 0) Console.WriteLine($"d1={xa}x{ya}y+{za}=0");
            else if (ya < 0 && za < 0) Console.WriteLine($"d1={xa}x{ya}y{za}=0");
            else if (ya >= 0 && za < 0) Console.WriteLine($"d1={xa}x+{ya}y{za}=0");

            if (yb >= 0 && zb >= 0) Console.WriteLine($"d2={xb}x+{yb}y+{zb}=0");
            else if (yb < 0 && zb >= 0) Console.WriteLine($"d2={xb}x{ya}y+{zb}=0");
            else if (yb < 0 && zb < 0) Console.WriteLine($"d2={xb}x{yb}y{zb}=0");
            else if (yb >= 0 && zb < 0) Console.WriteLine($"d2={xb}x+{yb}y{zb}=0");

            if (yc >= 0 && zc >= 0) Console.WriteLine($"d3={xc}x+{yc}y+{zc}=0");
            else if (yc < 0 && zc >= 0) Console.WriteLine($"d3={xc}x{yc}y+{zc}=0");
            else if (yc < 0 && zc < 0) Console.WriteLine($"d3={xc}x{yc}y{zc}=0");
            else if (yc >= 0 && zc < 0) Console.WriteLine($"d3={xc}x+{yc}y{zc}=0");

            double a = xa * yb * zc;
            double b = xb * yc * za;
            double c = xc * ya * zb;
            double d = xc * yb * za;
            double e = zb * yc * xa;
            double f = zc * ya * xb;

            if (a + b + c - d - e - f == 0) Console.WriteLine("Sunt concurente");
            else if (a + b + c - d - e - f != 0) Console.WriteLine("Nu sunt concurente");

            Console.ReadKey();
        }

        private static void Coliniar(double xa, double xb, double yb, double ya, double xc, double yc)
        {
            double a = xa * yb;
            double b = xb * yc;
            double c = xc * xa;
            double d = xc * yb;
            double e = xa * yc;
            double f = xb * ya;

            if (a + b + c - d - e - f == 0) Console.WriteLine("Este coliniar");
            else if(a + b + c - d - e - f != 0) Console.WriteLine("NU este coliniar");
            
        }

        private static void ecDistanta(double Xa, double Xb, double Yb, double Ya)
        {
            double a = Math.Sqrt(Math.Pow((Xb - Xa),2) + Math.Pow((Yb - Ya),2));
            Console.WriteLine(a);
             
        }

        private static void ecDreapta(double Xa,double Xb,double Yb,double Ya)
        {
            double a = Ya - Yb;
            double b = Xa - Xb;
            double c = Xa * Yb - (Xb * Ya);
             if( b < 0 && c < 0) Console.WriteLine($"{a}x {-b}y {c}=0");
            else if ( b < 0 && c >= 0) Console.WriteLine($"{a}x +{-b}y +{c}=0");
            else if ( b > 0 && c >= 0) { Console.WriteLine($"{a}x -{b}y +{c}=0"); }
            else if ( b > 0 && c < 0) { Console.WriteLine($"{a}x -{b}y {c}=0"); }
            
        }
    }
}
