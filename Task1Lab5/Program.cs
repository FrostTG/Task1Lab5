using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            float[] array = new float[n];
            Console.WriteLine("Введите 7 чисел");
            float S = 0;            
            for (int i = 0; i < n; i++)
            {            
                array[i] = (float)Convert.ToDouble(Console.ReadLine()); //долго мучался пытаясь понять, как правильно записать данную строчку) Забыл про явное/неявное преобразование.
                S += array[i];
            }
            Console.WriteLine("Среднее арифметическое чисел равно {0:f2}",S / n);
            Console.ReadKey();
        }
    }
}
