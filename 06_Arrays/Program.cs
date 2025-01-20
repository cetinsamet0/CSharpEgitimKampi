using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //Değişken Türü [] new DiziAdı = new DeğişkenTürü[Eleman Sayısı];
            //string[] colors = new string[4];
            //colors[0] = "Kirmizi";
            //colors[1] = "Mavi";
            //colors[2] = "Yeşil";
            //colors[3] = "Pembe";


            //Console.WriteLine(colors[0].ToString());
            //string[] cities = new string[3];
            //cities[0] = "Ankara";
            //cities[1] = "İstanbul";
            //cities[2] = "İzmir";

            //Console.WriteLine(cities[0]);

            //int[] numbers = new int[100];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 300;
            //numbers[4] = 123;
            //numbers[56] = 32;

            //Console.WriteLine(numbers[56]);
            //Console.WriteLine(numbers[24]);

            //string[] citiess = {"Prag","Roma","Atina","İstanbul" };
            //Console.WriteLine(citiess[2]);
            //Console.WriteLine(citiess[1] + " " +citiess[3]);
            //int[] numbs = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.Write(numbs[2] + numbs[1]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Pink", "Yellow", "Green", "Black", "White" };
            //for(int i = 0; i<=colors.Length - 1; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 1, 2, 3,13,4,52,765,32,2134,5677,9,333};
            //Console.WriteLine("3'e Kalansız Bölünen Sayılar");
            //Console.WriteLine();
            //for(int i = 0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //char[] chars = { 'a', 'b', 'c', '+', '*' };
            //Console.WriteLine();
            //for(int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}
            //int[] myArray = { 99999, 12, 41, 23, 56, 89, 34, 5112, 5557, 893, 234, 12354, 67889 };
            //int maxNumber = myArray[0];
            //for(int i = 0;i<myArray.Length;i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber.ToString());    

            //int[] myArray = { 2,5,12,42,123,445,5532,12,4,5,6,7,812,1,46,732,34123,532451};
            //int maxNumber = myArray[0];
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine("En Büyük Sayı: " + maxNumber);

            //string[] persons = { "Ali", "Ahmet", "Mehmet" };
            //Console.WriteLine(persons.Length); 
            //int[] numbers = { 21, 3, 12, 65, 231, 541, 12, 54, 6, 74, 645, 756 };
            //Array.Sort(numbers);
            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] number2 = { 1, 2, 3, 4, 5, };
            //Array.Reverse(number2);
            //for(int n = 0; n < number2.Length; n++)
            //{
            //    Console.WriteLine(number2[n]);
            //}


            #endregion

            #region Dizi Metotları
            //string[] customers = {"Ali","Buse","Merve","Fatma","Buğra"};
            //int index = Array.IndexOf(customers,"Merve");
            //Console.WriteLine(index);
            //Console.WriteLine(index + 1);

            //int[] number = { 1, 2, 3, 5,6,7,12,54,634,12,45,676};
            //Console.WriteLine("Dizinin En Küçük Elemanı: "+ number.Min() + "Dizinin En Büyük Elemanı: " + number.Max());

            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for(int i = 0; i< cities.Length; i++)
            //{
            //    Console.Write($"Lütfen { i+1} .Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //for(int i = 0; i<cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //Console.Write("Kaç Tane Sayıyı Toplayacaksınız: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x);
            //int[] numbers = new int[x];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}.Sayıyı Giriniz:");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //int sum = 0;
            //for(int i=0; i<numbers.Length;i++)
            //{
            //    sum+= numbers[i];
            //}
            //Console.WriteLine(sum);
            int[] numbers = { 1, 4, 3, 21, 443, 123, 5667, 77, 45, 743, 123, 4156, 89, 652, 1235, 6677, 8866, 5, 53 };
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine("---------------");
            for(int i = 0; i < numbers.Length;i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine("---------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion

            Console.Read();
        }
    }
}
