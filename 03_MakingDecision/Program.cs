using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //string password;
            //Console.Write("Lütfen şifreyi giriniz: ");
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Doğru şifreyi girdiniz içeri girin lütfen;");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış şifre tekrar deneyiniz!!!");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (country == "turkiye" & capital == "ankara")
            //{
            //    Console.Write("Doğru");
            //}
            //else
            //{
            //    Console.Write("Yanlış");
            //}

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav 1'i Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2'i Giriniz: ");
            //exam2  = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3'ü Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;

            //if(average <= 50 & average > 0)
            //{
            //    Console.Write("Vasat");
            //}
            //else if(average > 50 & average <=70 )
            //{
            //    Console.Write("Sonuç:Orta");
            //}
            //else if(average > 70 & average <= 84)
            //{
            //    Console.Write("Sonuç:İyi");
            //}
            //else if(average > 84 & average <= 100)
            //{
            //    Console.Write("Sonuç:Çok İyi");
            //}
            //else
            //{
            //    Console.Write("Hata!");
            //}

            //  
            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if(city=="adana" | city=="ankara" | city == "bursa")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen bir kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("Yanlış kullanıcı adını girdiniz!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Hojjgeldiniz");
            //}
            #endregion
            #region Mod İşlemleri
            // Bir sayının başka bir sayıya bölümünden kalanının veren sembol %
            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("Sayı 1'in sayı 2'ye bölümünden kalan: " + result);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Çift Sayı");

            //}
            //else
            //{
            //    Console.Write("Tek Sayı");
            //}
            #endregion
            #region Char Değişkenler İle Karar Yapıları

            //Console.Write("Lütfen bir takım seçiniz:");
            //char team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatsaray");

            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion
            #region Örnek Uygulma

            // Console.WriteLine("******** C# Eğitim Kampı Restoran *******");
            // Console.WriteLine("-------------------------------------");
            // Console.WriteLine("1-Ana Yemekler");
            // Console.WriteLine("2-Çorbalar");
            // Console.WriteLine("3-Pizzalar");
            // Console.WriteLine("4-İçecekler");
            // Console.WriteLine("5-Tatlılar");
            // Console.WriteLine("-------------------------------------");
            // Console.WriteLine();

            // string menuItem;
            // Console.Write("Görmek istediğiniz menüyü seçiniz: ");
            // menuItem = Console.ReadLine();

            // if(menuItem == "1")
            // {
            //     Console.WriteLine();
            //     Console.WriteLine("--------------- Ana Yemekler ---------------");
            //     Console.WriteLine();
            //     Console.WriteLine("1-Köri Soslu Tavuk");
            //     Console.WriteLine("2-Kızartma Tabağı");
            //     Console.WriteLine("3-Fasulye Pilav");
            //     Console.WriteLine("4-Fırında Somon");
            //     Console.WriteLine("5-Patlıcan Musakka");
            //     Console.WriteLine("--------------- Ana Yemekler ---------------");
            // }
            //else if (menuItem == "2")
            // {
            //     Console.WriteLine();
            //     Console.WriteLine("--------------- Çorbalar ---------------");
            //     Console.WriteLine();
            //     Console.WriteLine("1-Mercimek Çorbası");
            //     Console.WriteLine("2-Tarhana Çorbası");
            //     Console.WriteLine("3-Ezogelin Çorbası");
            //     Console.WriteLine("--------------- Çorbalar ---------------");
            // }
            //else if (menuItem == "3")
            // {
            //     Console.WriteLine();
            //     Console.WriteLine("--------------- Pizzalar ---------------");
            //     Console.WriteLine();
            //     Console.WriteLine("1-Akdeniz Pizza");
            //     Console.WriteLine("2-Margarita Pizza");
            //     Console.WriteLine("3-Tavuklu Pizza");
            //     Console.WriteLine("--------------- Pizzalar ---------------");
            // }
            //else if (menuItem == "4")
            // {
            //     Console.WriteLine();
            //     Console.WriteLine("--------------- İçecekler ---------------");
            //     Console.WriteLine();
            //     Console.WriteLine("1-Kola");
            //     Console.WriteLine("2-Ayran");
            //     Console.WriteLine("3-Su");
            //     Console.WriteLine("--------------- İçecekler ---------------");
            // }
            //else if (menuItem == "5")
            // {
            //     Console.WriteLine();
            //     Console.WriteLine("--------------- Tatlılar ---------------");
            //     Console.WriteLine();
            //     Console.WriteLine("1-Triliçe");
            //     Console.WriteLine("2-Kazandibi");
            //     Console.WriteLine("3-Sütlaç");
            //     Console.WriteLine("--------------- Tatlılar ---------------");
            // }




            #endregion
            #region Switch - Case

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Eküm"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı bir giriş yaptınız!"); break;
            //}



            #endregion
            #region Calculator
            int number1, number2,result;
            char process;
            Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            process = char.Parse(Console.ReadLine());

            Console.Clear();
            switch (process)
            {
                case '+': result = number1 + number2; Console.WriteLine("İşleminizin Sonucu: " + result);   break;
                case '-': result = number1 - number2; Console.WriteLine("İşleminizin Sonucu: " + result);   break;
                case '*': result = number1 * number2; Console.WriteLine("İşleminizin Sonucu: " + result);   break;
                case '/': result = number1 / number2; Console.WriteLine("İşleminizin Sonucu: " + result);   break;
                default: Console.WriteLine("Lütfen geçerli bir işlem giriniz!!"); break;
            
            }
            
        

            #endregion

            Console.Read();
        }
    }
}
