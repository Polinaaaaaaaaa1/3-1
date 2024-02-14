using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    public class one_dimensional
    {
        public int[] array;
        public int length;
        public one_dimensional(int length)
        {
            this.length = length;


            array = new int[length];
        }

        public void fill()
        {
            bool id = false;
            Console.WriteLine("введите true, если заполните массив с клавиатуры, иначе false");
            id = bool.Parse(Console.ReadLine());

            if (id == true)
            {
                for (int i = 0; i < length; i++)
                    array[i] = int.Parse(Console.ReadLine());
            }
            else
            {
                Random rand = new Random();
                for (int i = 0; i < length; i++)
                {

                    array[i] = rand.Next();
                }
            }
        }
        public void print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
        public void average()
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += array[i];

            }
            Console.Write("среднее значение ");
            Console.WriteLine(sum / length);

        }
        public void delete100()
        {
            int count2 = 0;
            for (int i = 0; i < length; i++)
            {
                if (array[i] > 100)
                {
                    count2++;

                }
            }

            int[] array2 = new int[length - count2];
            int count3 = 0;
            for (int i = 0; i < length; i++)
            {
                if (array[i] < 100)
                {
                    count3++;
                    array2[count3 - 1] = array[i];
                }
            }
            Console.Write("массив без эл-тов, больших 100 ");
            Console.WriteLine("[{0}]", string.Join(", ", array2));
        }
        public void delete_repeated()
        {
            int r = 0;
            for (int i = 0; i < length; i++)
            {
                int a = array[i];

                int c = 0;
                for (int j = 0; j < length; j++)
                {
                    if (array[j] == a)
                    {
                        c++;
                    }

                }
                if (c < 2)
                {
                    r++;
                }
            }
            int[] array3 = new int[r];
            int d = 0;
            for (int i = 0; i < length; i++)
            {
                int a = array[i];


                int c = 0;
                for (int j = 0; j < length; j++)
                {

                    if (array[j] == a)
                    {
                        c++;
                    }
                }
                if (c < 2)
                {
                    array3[d] = a;
                    d++;
                }
            }
            Console.Write("массив без повторяющихся эл-тов  ");
            Console.WriteLine("[{0}]", string.Join(", ", array3));
        }


    }
}
