using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_1
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("длина одномерного массива");
            int length = int.Parse(Console.ReadLine());
            
            one_dimensional Array = new one_dimensional(length);

            Array.fill();
            Array.print();
            Array.average();
            Array.delete100();
            Array.delete_repeated();

            Console.Write("введите длину многомерного массива");
            int length2 = int.Parse(Console.ReadLine());
            Console.Write("введите ширину многомерного массива");
            int heigth2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите true, если заполните массив с клавиатуры, иначе false") ;
            bool id2 = bool.Parse(Console.ReadLine());
            multidimensional Array2 = new multidimensional(length2,heigth2,id2);
            Array2.input();
            Array2.print();
            Array2.average2();
            Array2.print_reverse_order();

            Console.WriteLine("введите количествео строк зубчатого массива");
            int heigth3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите true, если заполните массив с клавиатуры, иначе false");
            bool id3 = bool.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] array_of_lengths = new int[heigth3];   
            for (int i = 0; i < heigth3; i++)
            {
                Console.WriteLine($"введите количество эл-тов в {i+1} строке зубч массива");
                array_of_lengths[i] = int.Parse(Console.ReadLine());
            }
            jagged Array3 = new jagged(heigth3,id3, array_of_lengths);
            Array3.input();
            Array3.print();
            Array3.average_in_all();
            Array3.average3();
            Array3.replace_even();
        }
    }
}
