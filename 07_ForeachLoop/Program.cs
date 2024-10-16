using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngusu

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 28, 48, 98, 129, 205, 6579 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 28, 48, 98, 129, 205, 6579 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //{
            //    Console.WriteLine(i);
            //}
            //}
            //int[] numbers = { 45, 28, 48, 98, 129, 205, 6579 };

            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;

            //}
            //Console.WriteLine(total);

            //List<int> number = new List<int>()
            //{
            //    1,2,3,4,5
            //};
            //foreach (int x in number)
            //{
            //    Console.WriteLine(x);
            //}






            #endregion

            #region Örnek sınav sistemi uygulaması

            //Console.WriteLine("c# eğitim kampı sınav uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("sınıfınızda kaç öğrenci var: ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------");

            ////öğrenci isim ve not ortalamarını saklayan diziler
            //string[] studentNames=new string[studentCount];
            //double[] studentExamAverage=new double[studentCount];


            //for (int i = 0; i < studentCount; i++)
            //{

            //    Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;
            //    //her öğrenci içiin 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz: ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult+= value;//notları toplama
            //    }
            //    studentExamAverage[i] = totalExamResult / 3;

            //}
            ////öğrencilerin ortalamsı ve geçip kalma durumları
            //for (int i = 0; i < studentCount; i++)
            //{

            //    Console.WriteLine($"{studentNames[i]} adlı öğrenci rtalaması:{studentExamAverage[i]}");
            //    if (studentExamAverage[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adli öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adli öğrenci dersten kaldı");
            //    }
            //}



            #endregion
            Console.Read();

        }
    }
}
