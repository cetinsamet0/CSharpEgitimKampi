using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Main_Subjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Hello World");
            //Console.Write("Selam");
            //Console.WriteLine("******** Yemek Kategorileri ********");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");            
            //Console.WriteLine("5-Tatlılar");            
            //Console.WriteLine("6-İçecekler");            
            #endregion

            #region String Değişkenler
            //string
            //Değişken_türü Değişken_Adi;
            //string name;
            //name = "Hasan";
            //Console.WriteLine(name);
            //Console.WriteLine(name + 4 + 4);

            //string customerName, customerSurname,customerEmail, customerPhone,
            //    district,city;
            //customerName = "Ali";
            //customerSurname = "Yücel";
            //customerEmail = "deneme@gmail.com";
            //customerPhone = "+90 554 445 45 45";
            //city = "Antalya";
            //district = "Alanya";

            //Console.WriteLine("********** Müşteri Bilgileri *********");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri Adı Soyadı: " + customerName + " " + customerSurname);
            //Console.WriteLine("Müşteri Telefon: " + customerPhone);
            //Console.WriteLine("Müşteri E-Mail: " + customerEmail);
            //Console.WriteLine("Müşteri Şehir:" + city + "/" + district);
            //Console.WriteLine("--------------------------------------");
            //customerName = "Aysegül";
            //Console.WriteLine(customerName);

            #endregion

            #region Int Değişkenler
            //int 
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Fiyatı *****");
            Console.WriteLine("---------------------------");
            Console.WriteLine("-----Hamburger: " + hamburgerPrice +" TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            int hamburgerCount;
            int pizzaCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int lemonadeCount;

            hamburgerCount = 3;
            pizzaCount = 1;
            cokeCount = 3;
            waterCount = 5;
            friesCount = 2;
            lemonadeCount = 0;

            int hamburgerTotalPrice = hamburgerCount * hamburgerPrice;
            int pizzaTotalPrice = pizzaCount * pizzaPrice;
            int cokeTotalPrice = cokeCount * cokePrice;
            int waterTotalPrice = waterCount * waterPrice; 
            int friesTotalPrice = friesCount * friesPrice;
            int lemonadeTotalPrice = lemonadeCount * lemonadePrice;
            int allTotalPrice = hamburgerTotalPrice + pizzaTotalPrice + cokeTotalPrice + waterTotalPrice + friesTotalPrice + lemonadeTotalPrice;


            Console.WriteLine("***** Toplam Fiyat *****");
            Console.WriteLine("---------------------------");
            Console.WriteLine("-----Toplam Hamburger Fiyatı: " + hamburgerTotalPrice + " Tl");
            Console.WriteLine("-----Toplam Pizza Fiyatı: " + pizzaTotalPrice + " Tl");
            Console.WriteLine("-----Toplam Kola Fiyatı: " + cokeTotalPrice + " Tl");
            Console.WriteLine("-----Toplam Su Fiyatı: " + waterTotalPrice + " Tl");
            Console.WriteLine("-----Toplam Kızartma Fiyatı: " + friesTotalPrice + " Tl");
            Console.WriteLine("-----Toplam Limonata Fiyatı: " + lemonadeTotalPrice + " Tl");
            Console.WriteLine("---------------------------");
            Console.WriteLine("-----Toplam Fiyatı: " + allTotalPrice + " Tl");
            Console.WriteLine("---------------------------");




            #endregion

            Console.Read();
        }
    }
}
