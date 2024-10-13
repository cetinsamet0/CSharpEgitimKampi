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
            int i;
            for (i=1; i <= 1782; i++)
            {
                Console.WriteLine("Dosya Yükleniyor..." + i + "/1782" );
                Console.SetWindowSize(32,16);

            }

            Console.WriteLine("Bütün hepsi başarıyla kuruldu!");

            //BreakPoint Kullanımını Öğren 10.Dakika
            #endregion


            Console.Read();
        }
    }
}
