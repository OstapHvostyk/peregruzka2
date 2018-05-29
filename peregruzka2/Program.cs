using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace peregruzka2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix first = new Matrix();
            Matrix second = new Matrix();
            first.ini();
            second.ini();
            Matrix result = Math.Sum(first, second);
            result.show();
            Console.Write("1-e chislo");
            int a =int.Parse(Console.ReadLine());
            Console.Write("2-e chislo");
            int b = int.Parse(Console.ReadLine());
            int c = Math.Sum(a, b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
    class Matrix 
    {
        public int[,] mas = new int[2, 2];
        public void ini() 
        {
            for(int i=0;i<2;i++)
                for(int j=0;j<2;j++)
                {
                    Console.Write("[{0},{1}]=",i,j);
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public void show()
        { 
            for(int i=0;i<2;i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Masuv[{0},{1}]={2}",i,j,mas[i,j]);
                }
        }
    }
    static class Math
    {
        public static Matrix Sum (Matrix a, Matrix b)
        {
            Matrix result = new Matrix();
            for(int i=0;i<2;i++)
                for (int j = 0; j < 2; j++)
                {
                    result.mas[i, j] = a.mas[i, j] + b.mas[i, j];
                }
            return result;
        }
        public static int Sum(int a, int b)
        {
            return (a + b);
        }
    }
}
