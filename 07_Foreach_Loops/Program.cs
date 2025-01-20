using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1,2,3,4);
            //1:Değişkenin Türü
            //2:Değişkenin Adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "Adana", "Adıyaman", "Budapeşte", "Los Angeles" };
            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] myNumbers = { 12, 243, 12, 44, 55, 12, 5213, 45123, 531 };
            //foreach(int i in myNumbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int[] myNumbers = { 12, 243, 12, 44, 55, 12, 5213, 45123, 531 };
            //int total = 0;
            //foreach(int i in myNumbers)
            //{
            //    total+= i;
            //    Console.WriteLine(total);   
            //}
            //Console.WriteLine(total);

            //List <int> numbers = new List<int>()
            //{ 
            //    1,3,4,5,6,6,77,23,123,1424,13124,145,12,456,7
            //};
            //Console.WriteLine(numbers[3]);
            //int toplam = 0;
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);
            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);   

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Uygulama Sınavı *****");
            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç adet öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrenci adını giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;
                //Her öğrenci için 3 adet sınav notu girişi alma
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                studentExamAvg[i] = totalExamResult / 3;
            }
            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{studentNames[i]} adlı öğrencinin sınav ortalaması: {studentExamAvg[i]}");
                if (studentExamAvg[i]<50) {
                    Console.WriteLine($"{studentNames[i]} \t Kaldı");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} \t Geçti");
                }

            }

            #endregion

            Console.Read();
        }

           
            
        
    }
   

}
