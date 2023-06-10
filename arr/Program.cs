using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace arr
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] a =new int[4];
            int[,] b = { { 1, 2, 3 }, { 3, 2, 1 } };
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine("Введите элемент массива");    
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            int max=0, min=0;
            foreach(int x in a)
            {
                if(x > max) 
                max = x;
                if (x < min)
                    min = x;
            }
            int max1 = 0, min2 = 0;
            foreach (int x in b)
            { if(x > max1)
                    max1 = x;
            if(x < min2)
                    min2 = x;  
                        }
            if(max1 > max)
            { max = max1; }
            if (min2 > min)
            {
                min = min2;
            }
            int sum = 0; int s=0; int sum2 = 0;
            for (int x = 0; x < a.Length; x++)
            {
                sum += a[x];
                s *= a[x];
                if (a[x]%2 == 0)
                {
                    sum2 += a[x];
                }

            }
            for (int x = 0; x< b.Length; x++)
            {
                sum += b[x][x];
                s *= b[x][x];
            }

        }
    }
}
