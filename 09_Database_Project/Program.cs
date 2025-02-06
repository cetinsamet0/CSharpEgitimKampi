using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Database_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.Net
            Console.WriteLine("***** C# Veri Tabanı Uygulamalı Örnek *****");
            Console.WriteLine("-------------------------------------------");
            string tableNumber;
            
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");
            if(tableNumber == "1")
            {
                //SQL Veritabanına bağlantı kodu Category Tablosunun içindekileri ekrana yazdırır
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3LI12ND; initial Catalog=EgitimKampiDb; integrated security=true");
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Category", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item.ToString());

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Geçersiz Seçim!!!");
            }
           
            



            Console.Read();
        }
    }
}
