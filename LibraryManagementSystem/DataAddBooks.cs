using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class DataAddBooks
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-67F8JG8\SQLEXPRESS;Initial Catalog=Kütüphane_Yönetim;Integrated Security=True;TrustServerCertificate=True");
        public int KitapID { set; get; }
        public string KitapAdı { set; get; }
        public string YazarAdı { set; get; }
        public string YayınTarihi { set; get; }
        public string ResimYolu { set; get; }
        public string KitapDurumu { set; get; }

        public string KitapTürü { set; get; }

        public List<DataAddBooks> addBooksData()
        {
            List<DataAddBooks> listData = new List<DataAddBooks>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM books WHERE date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataAddBooks dab = new DataAddBooks();
                            dab.KitapID = (int)reader["id"];
                            dab.KitapAdı = reader["book_title"].ToString();
                            dab.YazarAdı = reader["author"].ToString();
                            dab.YayınTarihi = reader["published_date"].ToString();
                            dab.ResimYolu = reader["image"].ToString();
                            dab.KitapDurumu = reader["status"].ToString();
                            dab.KitapTürü = reader["book_type"].ToString();
                            listData.Add(dab);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanı bağlanırken hata oluştu: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}