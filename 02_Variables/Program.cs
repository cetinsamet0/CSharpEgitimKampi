using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.5;
            //Console.WriteLine(number);
            //Console.WriteLine("******** Fiyat Listesi ********");
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("--- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("--- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("--- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("--- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();
            //double appleGram, orangeGram, strawGram, potatoGram , tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.145;
            //strawGram = 0.760;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawTotalPrice =  strawberryPrice * strawGram;
            //double potataTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " TL " + "- Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " TL" );
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " TL " + "- Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " TL" );
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " TL " + "- Gramaj: " + strawGram + " - Toplam Tutar: " + strawTotalPrice + " TL" );
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " TL " + "- Gramaj: " + potatoGram + " - Toplam Tutar: " + potataTotalPrice + " TL" );
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + tomatoPrice + " TL " + "- Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " TL" );

            //double totalShoppingPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potataTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Toplam Sepet Tutarı: " + totalShoppingPrice + " TL");



            #endregion

            #region Char Değişkenler
            //ABCDEFG
            // " '
            // Char Değişken tanımlanırken tek tırnak kullanılır.
            //char symbol = 'a';
            //Console.WriteLine(symbol);  
            #endregion

            #region Klavyeden Veri Girişi

            //Console.WriteLine("******** CSharp Hava Yolları *********");
            //Console.WriteLine();

            //Console.WriteLine("Lütfen Yolcu Adı Ve Soyadını Giriniz!");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine("-------------------------");
            //Console.Write("Yolcu Kimlik No: " + passengerIdentityNumber + "\n" +"Yolcu Adı Soyadı: " +  passengerName + " " + passengerSurname + "\n" +"Yolcu İlçe Ve İl: " +
            //    passengerDistrict + " " + passengerCity + "\n" + "Yolcu Yaşı: " + passengerAge);  




            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler 

            //ABC12D
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = Convert.ToInt32(Console.ReadLine());
            //// Yada Aşşağıdaki gibi çevirilebilir
            //// shoesPrice = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairCount * chairPrice + tvPrice * tvCount;
            //Console.Write("Toplam Ödenmesi Gereken Tutar: " + totalPrice + " TL");




            #endregion

            #region Klavyden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = Convert.ToDouble(Console.ReadLine());
            ////exam1 = Double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = Double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.Write("Ortalamanız:" + result);

            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen Bir Cinsiyet Giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet: " + gender);
       

            #endregion

            Console.Read();



        }
    }
}
