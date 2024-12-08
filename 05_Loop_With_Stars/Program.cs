using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05_Loop_With_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("*");
            //    i++;
            //}
            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //int i = 1;

            //while(i<=10)
            //{
            //    Console.Write("*");
            //    i++;
            //}

            #endregion

            #region Her satırda 10 tane ve alt alta 10 tane yıldız olsun
            //int i = 1;

            //while (i <= 10)
            //{

            //    Console.WriteLine("**********");
            //    i++;
            //}
            #endregion

            #region Yıldızlar ile Dik Üçgen Oluşturma
            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Yıldızlar ile Ters Dik Üçgen Oluşturma
            //for(int i = 10; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Yatay Üçgen Oluşturma

            //for(int i = 1;i<=10;i++)
            //{
            //    for(int j = 1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int m = 10; m >= 0;m--)
            //{
            //    for(int k = 1; k<=m;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi İle Desen Oluşturma
            //Console.Write("Ne kadar büyük üçgen istiyorsun: ");
            //int n = int.Parse(Console.ReadLine());
            ////üst Kısım

            //for(int i = 1; i <= n; i++)
            //{
            //    for(int j = n-1;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1;k <= 2 * i - 1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////alt kısım
            //for(int i = n-1; i >= 1; i--)
            //{
            //    for(int j = n-1; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}





            #endregion

            #region Piramit

            //23.Dakikada Kaldım


            #endregion

            Console.Read();
        }
    }
}
