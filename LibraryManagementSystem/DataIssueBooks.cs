using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class DataIssueBooks
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-67F8JG8\SQLEXPRESS;Initial Catalog=Kütüphane_Yönetim;Integrated Security=True;TrustServerCertificate=True");

        public int KitapIslemID { set; get; }
        public string IslemNumarası { set; get; }
        public string AdSoyad { set; get; }
        public string Telefon { set; get; }
        public string EPosta { set; get; }
        public string KitapAdı { set; get; }
        public string YazarAdı { set; get; }
        public string VerisTarihi { set; get; }
        public string IadeTarihi { set; get; }
        public string Durum { set; get; }

        public string KitapTürü { set; get; }

        public List<DataIssueBooks> IssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM issues WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.KitapIslemID = (int)reader["id"];
                            dib.IslemNumarası = reader["issue_id"].ToString();
                            dib.AdSoyad = reader["full_name"].ToString();
                            dib.Telefon = reader["contact"].ToString();
                            dib.EPosta = reader["email"].ToString();
                            dib.KitapAdı = reader["book_title"].ToString();
                            dib.YazarAdı = reader["author"].ToString();
                            dib.VerisTarihi = reader["issue_date"].ToString();
                            dib.IadeTarihi = reader["return_date"].ToString();
                            dib.Durum = reader["status"].ToString();
                            dib.KitapTürü = reader["book_type"]?.ToString() ?? "";

                            listData.Add(dib);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }

        public List<DataIssueBooks> ReturnIssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM issues WHERE status = 'Not Return' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.KitapIslemID = (int)reader["id"];
                            dib.IslemNumarası = reader["issue_id"].ToString();
                            dib.AdSoyad = reader["full_name"].ToString();
                            dib.Telefon = reader["contact"].ToString();
                            dib.EPosta = reader["email"].ToString();
                            dib.KitapAdı = reader["book_title"].ToString();
                            dib.YazarAdı = reader["author"].ToString();
                            dib.VerisTarihi = reader["issue_date"].ToString();
                            dib.IadeTarihi = reader["return_date"].ToString();
                            dib.Durum = reader["status"].ToString();
                            dib.KitapTürü = reader["book_type"]?.ToString() ?? "";

                            listData.Add(dib);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex);
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