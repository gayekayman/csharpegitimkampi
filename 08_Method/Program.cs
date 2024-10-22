using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Merve Çınar");
            //    Console.WriteLine("Ayşe Yıldız");
            //}
            //CustomerList();
            //void Top()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Top();

            #endregion

            #region Geriye değer döndurmeyen string parametreli metotlar

            //void Yazdır(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //Yazdır("Gaye KAYMAN");

            #endregion

            #region Geriye değer döndurmeyen int parametreli metotlar

            //void Toplam(int number1,int number2,int number3)
            //{
            //    int result=number1+ number2+ number3;
            //    Console.WriteLine(result);
            //}
            //Toplam(5 , 10 , 12);
            #endregion

            #region Geriye değer dönduren metotlar 

            //string CustomerName()
            //{
            //    return "buse yıldız";
            //}
            //CustomerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name+" " + surname;


            //}
            //Console.WriteLine(studentCard());
            #endregion

            #region Geriye değer dönduren string paremetreli metotlar 
            //string CountryCard(string counrtyName, string capital, string flagColor)
            //{
            //    string cardInfo = "ulke: " + counrtyName + " Başkent: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("ulke adını gir: ");
            //x = Console.ReadLine();

            //Console.Write("başkent gir: ");
            //y = Console.ReadLine();

            //Console.Write("bayrak rengi gir: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));


            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci geçti";
            //    }
            //    else
            //    {
            //        return student + " isimli Öğrenci başarısız";
            //    }
            //}
            //Console.WriteLine(ExamResult("Gaye", 68, 97, 89));
            //Console.WriteLine(ExamResult("Ali", 50, 30, 23));
            #endregion

            Console.Read();
        }
    }
}
