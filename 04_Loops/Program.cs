using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngusu

            //int i;

            //for ( i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("c# eğitim kampı");
            //}

            //for (i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (i = 1; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lutfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue= int.Parse(Console.ReadLine());

            //for (int i = 1; i <=finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngusu Karar Yapıları İle Kullanımı

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //   totalValue += i;

            //}
            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i %2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda " + bacterium);
            //}



            #endregion

            #region While Döngusu 
            //int i= 1;

            //while (i<=10) 
            //{ 
            //Console.WriteLine("merhaba dönguler");
            //    i++;
            //}
            //int i = 1;
            //while (i<=10) 
            //{
            //    if (i%3==0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //int i = 1;
            //int totalValue = 0;
            //while (i<=10) 
            //{
            //    totalValue += i;
            //    i++;
            //}
            //Console.WriteLine(totalValue);

            #endregion

            #region Örnek sınav sorusu

            //klavyeden girilen 3 basamaklı sayının basamkları toplamını hesaplayan kod
            //Console.Write("3 basamaklı sayı giriniz: ");

            //int number=int.Parse(Console.ReadLine());

            //int one, ten, hundred, sum;

            //one = number % 10;
            //hundred= number / 100;
            //ten = (number % 100)/10;
            //sum = one+hundred+ten;
            //Console.WriteLine("Rakamları toplamı: " + sum);
            
            #endregion
            Console.Read();
        }
    }
}
