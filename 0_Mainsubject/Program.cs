using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Mainsubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YAZDIRMA KOMUTLARI
            //Console.WriteLine("merhaba dunya");
            //Console.Write("selam");

            //Console.WriteLine("***yemek kategorileri***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-soğuk başlangıçlar");
            //Console.WriteLine("4-salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***yemek kategorileri***");
            #endregion

            #region  sTRiNG DEĞİŞKENLER
            ////sTRiNG değişkenler
            ////string name;
            ////name = "Gaye";
            ////Console.Write(name);
            //string customerName;
            //string customersurname;
            //string customerEmail, district, city;
            //customerName = "Ayşe";
            //customersurname = "Kaya";
            //customerEmail = "deneme@gmail.com";
            //district = "kadıköy";
            //city = "istanbul";

            //Console.WriteLine("****Rezervasyon Bilgileri***");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Muşteri: "+ customerName + " " + customersurname );
            //Console.WriteLine("İletişim Bilgileri: " + customerEmail + " " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine();

            //customerName = "Ali";
            //customersurname = "Çınar";
            //customerEmail = "test@gmail.com";
            //district = "sapanca";
            //city = "sakarya";

            //Console.WriteLine("****Rezervasyon Bilgileri***");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Muşteri: " + customerName + " " + customersurname);
            //Console.WriteLine("İletişim Bilgileri: " + customerEmail + " " + district + "/" + city);
            //Console.WriteLine("---------------------------------------------");



            #endregion
            #region INT DEĞİŞKENLER
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friePrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("*****REsTORAN MENU FİYATI******");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Kola: " + cokePrice + "TL");
            Console.WriteLine("-----su: " + waterPrice + "TL");
            Console.WriteLine("-----Kızartma: " + friePrice + "TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice+ "TL");
            Console.WriteLine();
            Console.WriteLine("*****REsTORAN MENU FİYATI******");
            Console.WriteLine();

            int hamburgeCount;
            int cokeCount;
            int waterCount;
            int frieCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHmburgerPrice = 0;
            int totalCokePrice;
            int totaLWaterPrice;
            int totalFriePrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            hamburgeCount= 3;
            cokeCount = 3;
            waterCount = 3;
            frieCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHmburgerPrice = hamburgeCount * hamburgerPrice;
            Console.WriteLine("------------");
            Console.WriteLine("hamburger tutarı: " + totalHmburgerPrice + "tl");  
            totalCokePrice= cokeCount* cokePrice; 
            
            Console.WriteLine("Kola tutarı: " + totalCokePrice + "tl");
            totalFriePrice= frieCount* friePrice;
            
            Console.WriteLine("kızartma tutarı: " + totalFriePrice + "  tl ");
            totalPizzaPrice= pizzaCount* pizzaPrice;
         
            Console.WriteLine("Pizza tutarı: " + totalPizzaPrice + "tl");
            totaLWaterPrice=waterCount* waterPrice;
            
            Console.WriteLine("su tutarı: " + totaLWaterPrice + " tl");
            totalLemonadePrice= lemonadeCount* lemonadePrice;
            
            Console.WriteLine("Limonata tutarı : " + totalLemonadePrice + " tl ");
            Console.WriteLine();
            Console.WriteLine("Ödenmesi gereken toplam tutar= " + (totalLemonadePrice + totalCokePrice + totalFriePrice + totalPizzaPrice
                + totaLWaterPrice + totalHmburgerPrice + " tl "));



            #endregion
            
            Console.Read();
        }
    }
}
