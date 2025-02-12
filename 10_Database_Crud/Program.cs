using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _10_Database_Crud
{
    internal class Program
    {
       
        static void Main()
        {

            void listele()
            {
                SqlConnection connection4 = new SqlConnection("Data Source=DESKTOP-3LI12ND; initial catalog=EgitimKampiDb; integrated security=true");
                connection4.Open();
                SqlCommand command2 = new SqlCommand("SELECT * FROM Tbl_Product", connection4);
                SqlDataAdapter adaptor = new SqlDataAdapter(command2);
                DataTable table = new DataTable();
                adaptor.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item2 in row.ItemArray)
                    {
                        Console.Write(item2.ToString() + " ");
                    }
                    Console.WriteLine();
                }
            }

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3LI12ND; initial catalog=EgitimKampiDb; integrated security=true");

            /* Crud
             * C => Create
             * R => Read
             * U => Update
             * D => Delete
            */
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1-Kategori Ekleme");
            Console.WriteLine("2-Ürün Ekleme");
            Console.WriteLine("3-Ürün Listeleme");
            Console.WriteLine("4-Ürün Silme");
            Console.WriteLine("5-Ürün Güncelleme");
            Console.WriteLine("-------------------------------------");
            Console.Write("Ne yapmak istiyorsunuz: ");
            

            string tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------");
            if (tableNumber == "1")
            {
                Console.Write("Eklemek İstediğiniz Kategori Adı: ");
                string categoryName = Console.ReadLine();

                connection.Open();
                SqlCommand command = new SqlCommand("insert into Tbl_Category (CategoryName) values (@p1)",connection);
                command.Parameters.AddWithValue("@p1",categoryName);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Kategori Başarı İle Eklendi!!!");
                Console.WriteLine("--------------------------------");

              
                connection.Open();
                SqlCommand command1 = new SqlCommand("SELECT * FROM Tbl_Category", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command1);
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
            else if(tableNumber == "2")
            {
                string productName;
                decimal productPrice;
                Console.Write("Ürün Adı: ");
                productName = Console.ReadLine();
                Console.Write("Ürün Fiyatı: ");
                productPrice =int.Parse(Console.ReadLine());
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Tbl_Product (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
                command1.Parameters.AddWithValue("@productName", productName);
                command1.Parameters.AddWithValue("@productPrice", productPrice);
                command1.Parameters.AddWithValue("@productStatus",true);
                command1.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Ürün eklemi Başarılı");
                
            }
            else if(tableNumber == "3")
            {
                connection.Open();
                SqlCommand commandlisting = new SqlCommand("SELECT * FROM Tbl_Product",connection);
                SqlDataAdapter adapter = new SqlDataAdapter(commandlisting);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                foreach(DataRow row in tablo.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item.ToString() + " ");

                    }
                    Console.WriteLine();
                    Console.WriteLine("---------------------");
                }



            }
            else if(tableNumber == "4")
            {
                connection.Open();
                SqlCommand command2 = new SqlCommand("SELECT * FROM Tbl_Product",connection);
                SqlDataAdapter adaptor = new SqlDataAdapter(command2);
                DataTable table = new DataTable();
                adaptor.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    foreach(var item2 in row.ItemArray)
                    {
                        Console.Write(item2.ToString() + " ");
                    }
                    Console.WriteLine();
                }
               

                Console.Write("Silmek istediğiniz ürünün ID değerini giriniz: ");
                int productID = int.Parse(Console.ReadLine());
                SqlCommand productDelete = new SqlCommand("DELETE FROM Tbl_Product WHERE productId = @p1",connection);
                productDelete.Parameters.AddWithValue("@p1",productID);
                productDelete.ExecuteNonQuery();
                Console.WriteLine("Ürün başarıyla silindi!!!");
                connection.Close();

            }
            else if(tableNumber == "5")
            {
                listele();
                Console.Write("Güncellemek istedeğiniz ürünün ID değerini giriniz: ");
                int productID = int.Parse(Console.ReadLine());
                Console.Write("Ürünün yenin adını giriniz: ");
                string productName = Console.ReadLine();
                Console.Write("Ürünün fiyatını giriniz: ");
                decimal productPrice = Convert.ToDecimal(Console.ReadLine());
                connection.Open();
                SqlCommand updateProduct = new SqlCommand("UPDATE Tbl_Product SET ProductName=@p1, ProductPrice=@p2 WHERE ProductId = @p3",connection);
                updateProduct.Parameters.AddWithValue("@p1",productName);
                updateProduct.Parameters.AddWithValue("@p2",productPrice);
                updateProduct.Parameters.AddWithValue("@p3",productID);
                updateProduct.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Ürün başarıyla güncellendi!!!");
                listele();

            }
            Console.Read();
        }
    }
}
