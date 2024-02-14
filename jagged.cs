using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    public class jagged
    {
        int[][] array;
        int heigth;
        bool id;
        int[] array_of_lengths;
        public jagged(int heigth, bool id, int[] array_of_lengths)
        {
            this.heigth = heigth;
            array = new int[heigth][];
            this.id = id;
            this.array_of_lengths = array_of_lengths;
        }
        public void input()
        {
            if (id == true)
            {
                for (int i = 0; i < heigth; i++)
                {

                    int[] nums = new int[array_of_lengths[i]];
                    for (int k = 0; k < nums.Length; k++)
                    {
                        Console.Write($"{i} строка {k} эл-т массива: ");
                        nums[k] = int.Parse(Console.ReadLine());
                    }
                    array[i] = nums;

                }
            }
            else
            {
                Random rand = new Random();
                for (int i = 0; i < heigth; i++)
                {

                    int[] nums = new int[array_of_lengths[i]];
                    for (int k = 0; k < nums.Length; k++)
                    {
                        nums[k] = rand.Next();
                    }
                    array[i] = nums;

                }
            }

        }
        public void print()
        {
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
        public void average_in_all()
        {
            float sum = 0;
            float count = 0;
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    sum += array[i][j];
                    count++;
                }
            }
            Console.WriteLine($"среднее во всем массиве {sum / count}");

        }
        public void average3()
        {
            for (int i = 0; i < heigth; i++)
            {
                float sum = 0;
                float count = 0;
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    sum += array[i][j];
                    count++;

                }
                Console.WriteLine($"среднее в {i + 1} строке {sum / count}");

            }
        }
        public void replace_even()
        {
            int k = 1;
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        k = j * k;
                    }

                }

            }
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = k;
                    }

                }

            }

        }

    }
}
