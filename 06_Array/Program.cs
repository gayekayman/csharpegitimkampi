using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region temel dizi örnekleri

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "lion";
            //cities[3] = "Kahire";
            //cities[4] = "Uskup";

            //Console.WriteLine(cities[4]);

            //int[] numbers=new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "prag", "roma", "atina", "ankara" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizinin tum elemanlarını listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] number = { 4, 85, 96, 75, 125, 635, 488, 520, 7456 };

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100};
            //int maxNumber=myArray[0];

            //for (int i = 1; i <myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);


            #endregion

            #region dizi metotları


            //string[] people = { "ahmet", "ayşe", "ali", "buse", "cem", "deniz" };
            //Console.WriteLine(people.Length);

            //int[] numbers = { 45, 85, 77, 56, 98 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] persons = { "ali", "buse", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(persons, "merve");
            //Console.WriteLine(index);



            #endregion

            #region kullanıcıdan değer alma dizi için

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"lutfen {i + 1}.şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10,20, 30,40,50};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,0};
            //Console.WriteLine("çift sayılar: ");
            //    for (int l = 0; l <num.Length; l++)
            //{
            //    if (num[l] % 2 == 0)
            //    {
            //        Console.WriteLine(num[l]);
            //    }

            //}
            //Console.WriteLine("tek sayılar: ");
            //for (int l = 0; l < num.Length; l++)
            //{
            //    if (num[l] % 2 == 1)
            //    {
            //        Console.WriteLine(num[l]);
            //    }

            //}

            #endregion

            Console.Read();
        }
    }
}
