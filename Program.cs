using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101._1
{
   
    internal class Program
    {
        static void MinMaxValue(int[,] array)
        {
            int  min_value = array[0,0];
            int max_value = 0;
            int row = 0; 
            int col = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j]< min_value)
                    {
                        min_value =array[i, j];
                        row = i;
                        col = j;
                    }

                }
               
            }
            Console.Write("Min = " + min_value.ToString() + " (" + row.ToString() + " " + col.ToString() + ")");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max_value<array[i, j])
                    {
                        max_value = array[i, j];
                        row = i;
                        col = j;
                    }

                }


            }
            Console.Write("Max = " + max_value.ToString() + " (" + row.ToString() + " " + col.ToString() + ")");
        }
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[m,n];
            for (int i =0; i < m; i++)
            {
                for(int j=0; j < n; j++)
                {
                    Console.Write("Nhap phan tu: ");
                    array[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            //in ma tran
            //foreach(int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //in ra cac phan tu chia het cho 3
            //foreach(int i in array)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Tim max, min
            //MinMaxValue(array);

            int[,] evenArray = new int[m,n];
            int[,] oddArray = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] %2==0)
                    {
                        evenArray[i, j] = array[i, j];
                        oddArray[i, j] = 0;
                    }
                    else
                    {
                        evenArray[i, j] = 0;
                        oddArray[i, j] = array[i, j];
                    }
                }
            }
            Console.WriteLine("mang chan: ");
            foreach( int i in evenArray) Console.WriteLine(i);
            Console.WriteLine("Mang le: ");
            foreach (int i in oddArray) Console.WriteLine(i);
            
        }
    }
}
