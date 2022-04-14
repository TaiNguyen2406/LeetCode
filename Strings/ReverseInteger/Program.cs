using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
           // Console.WriteLine(Reverse(x));
            //x = 123;
            //Console.WriteLine(Reverse(x));
            //x = -123;
            //Console.WriteLine(Reverse(x));
            //x = 0;
            //Console.WriteLine(Reverse(x)); 
            //x = 1534236469;
            //Console.WriteLine(Reverse(x));
            x = -8192;
            Console.WriteLine(Reverse(x));
        }

        public static int Reverse(int x)
        {
            if (x > int.MaxValue || x < int.MinValue) return 0;
            var d = 0;
            for (int i = numDigits(x) - 1; i >=0 ; i--)
            {
                // Console.WriteLine(x % 10 * IntPow(10, (uint)i));
                if (d + x % 10 * Math.Pow(10,i) > int.MaxValue || d + x % 10 * Math.Pow(10, i) < int.MinValue) 
                    return 0;
                d += x % 10 * (int) Math.Pow(10,i);
                
                x /= 10;
                Console.WriteLine(d);
            }
            return d;

        }

        public static int IntPow(int x, uint pow)
        {
            double ret = 1;
            while (pow != 0)
            {
                //Console.WriteLine($"Before ret=: {ret}");
                //Console.WriteLine($"Before x=: {x}");
                if ((pow & 1) == 1)
                    ret *= x;
                //Console.WriteLine($"After ret=: {ret}");
                x *= x;
                //Console.WriteLine($"After x=: {x}");
                //Console.WriteLine($"Before: {Convert.ToString(pow, toBase: 2)}");
                pow >>= 1;
                //Console.WriteLine($"After: {Convert.ToString(pow, toBase: 2)}");
            }
            return (int)(ret-1);
        }

        public static int numDigits(int n)
        {
            if (n < 0)
            {
                n = (n == Int32.MinValue) ? Int32.MaxValue : -n;
            }
            if (n < 10) return 1;
            if (n < 100) return 2;
            if (n < 1000) return 3;
            if (n < 10000) return 4;
            if (n < 100000) return 5;
            if (n < 1000000) return 6;
            if (n < 10000000) return 7;
            if (n < 100000000) return 8;
            if (n < 1000000000) return 9;
            return 10;
        }
    }
}
