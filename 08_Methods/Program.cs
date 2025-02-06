using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Furkan Yıldız");
            //    Console.WriteLine("Sıla Güner");
            //}
            //customerList();
            //for(int i = 0; i < 999; i++)
            //{
            //    customerList();
            //}
            #endregion
            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ali Fuat");
            //void asasov(int x, int y)
            //{

            //    Console.WriteLine(x);
            //    Console.WriteLine(y);
            //    int z = 0;
            //    z = x * y;
            //    Console.WriteLine(z);

            //}
            //asasov(5,25);

            //void myMethod(string name,string surname)
            //{
            //    string fullname = name + "\t" + surname;
            //    Console.WriteLine($"Müşterinin Tam Adı: {fullname}");
            //}
            //myMethod("Ali","Veli") ;

            #endregion
            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void myIntMethod(int z , int x ,int y)
            //{
            //    int result = z * x * y;
            //    Console.Write(result);
            //}
            //int[] answ = { 1, 2, 4 };
            //for (int i = 0; i < answ.Length; i++)
            //{
            //    Console.Write($"{i+1}. Değeri giriniz: ");
            //    answ[i] = int.Parse(Console.ReadLine());

            //}

            //myIntMethod(answ[0], answ[1], answ[2]);
            #endregion
            #region Geriye Değer Döndüren Metotlar
            //string customerName()
            //{
            //    return "Buse Yıldız";
            // Bu metot ekrana bir şey yazdırmaz
            //}
            //customerName();
            //string studentCard()
            //{
            //    string name = "Adem";
            //    string surname = "Can";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentCard());
            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar
            //string countryCard(string countryName,string capital,string flagColor)
            //{
            //    string countryInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return countryInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülkenin İsmini Giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Ülkenin Başkentini Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Ülkenin Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(countryCard(x,y,z));

            #endregion
            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}

            //Console.WriteLine(Sum(5, 10));
            //Console.WriteLine(Sum(10,45));
            //string examResult(string studentName, int exam1,int exam2)
            //{
            //    int result = (exam1 + exam2) / 2;
            //    if(result < 50)
            //    {
            //        return studentName + "Öğrenci kaldı";

            //    }

            //    else {
            //        return studentName + "Öğrenci geçti";
            //    }

            //}
            //Console.WriteLine(examResult("Ali", 50, 60));
            #endregion
            #region Örnek Uygulama
            #endregion

            Console.Read();
        }
    }
}
