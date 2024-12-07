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
            #region For Döngüleri
            //For(x;y;z)
            //x başlangıç değeri
            //y bitiş değeri
            //z artış yada azalış miktarı
            //int i;
            //for (i=1; i <= 1782; i++)
            //{
            //    Console.WriteLine("Dosya Yükleniyor..." + i + "/1782" );
            //    Console.SetWindowSize(32,16);

            //}

            //Console.WriteLine("Bütün hepsi başarıyla kuruldu!");

            //for(int i = 1; i <=50; i+=3)
            //{
            //    Console.WriteLine(i);  
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz sayı adedini giriniz: ");
            //int finishValue = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen kaçtan başlayacağına karar veriniz: ");
            //int startValue = int.Parse(Console.ReadLine());
            //for (int i = startValue; i <= finishValue; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for(int i = 1; i >=-100; i--)
            //{

            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;
            //for(int i = 1;i<10;i++ )
            //{
            //    totalValue+=i;
            //    Console.WriteLine(totalValue);
            //}

            //int totalValue = 0;
            //for(int i=1;i<100;i+=3)
            //{
            //    if (i % 2 == 0)
            //    {

            //        totalValue += i;
            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("-------------");
            //Console.WriteLine(totalValue);  

            //Console.WriteLine("Kaça kadar olan sayının kalanlarını görmek istiyorsun? ");
            //int value = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sayı kaça tam bölünsün? ");
            //int divide = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //for(int i = 1; i <= value; i++)
            //{
            //    if (i % divide == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int count = 0;
            //for(int i = 1;i<=70; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;

            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 0;
            //int time = 24 * 60;
            //for(int i = 1; i <= time; i++)
            //{
            //    bacterium +=2;
            //    Console.WriteLine(i+". Saatin Sonundaki Bakteri Sayısı: "+bacterium );
            //}

            #endregion

            #region While Döngüsü
            //While(Şart)
            //{
            //İşlemler
            //}
            //int i = 0;
            //while (i < 10)
            //{

            //    Console.WriteLine(i);
            //    i++;

            //}
            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //        i+=4;
            //    }
            //    else
            //    {
            //        i++;
            //    }

            //}

            //int i = 1;
            //int sum = 0;
            //while(i <=10)
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu
            //30.Dakikada Kaldım
            #endregion


            Console.Read();
        }
    }
}
