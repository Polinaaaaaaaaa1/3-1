using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    public class multidimensional
    {
        public int length;
        public int heigth;
        public int[,] array;
        bool id;
        public multidimensional(int length, int heigth, bool id2)
        {
            this.length = length;
            this.heigth = heigth;
            array = new int[length, heigth];
            id = id2;
        }

        public void input()
        {
            if (id == false)
            {
                Random rand = new Random();
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < heigth; j++)
                    {
                        array[i, j] = rand.Next();

                    }
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < heigth; j++)
                    {
                        array[i, j] = int.Parse(Console.ReadLine());

                    }
                }

            }
        }
        public void print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void average2()
        {
            float sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];

                }
            }
            Console.Write("среднее занчение ");
            Console.WriteLine(sum / (length * heigth));
        }
        public void print_reverse_order()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("в обратном порядке");
            for (int i = 0; i < array.GetLength(0); i++)
            {

                if (i % 2 != 0)
                {
                    for (int k = array.GetLength(1) - 1; k >= 0; k--)
                    {
                        Console.Write(array[i, k] + "\t");
                    }

                    Console.WriteLine();
                }

                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }

                    Console.WriteLine();
                }




            }
        }
    }
}
