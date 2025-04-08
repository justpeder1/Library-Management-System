using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryManagementSystem
{
    public partial class BooksType : UserControl
    {
        private readonly string connectionString = @"Data Source=DESKTOP-67F8JG8\SQLEXPRESS;Initial Catalog=Kütüphane_Yönetim;Integrated Security=True;TrustServerCertificate=True";
        public BooksType()
        {
            InitializeComponent();
        }

        private bool isChartLoaded = false;

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            LoadChartData();
        }

        private void LoadChartData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string query = @"SELECT book_type, COUNT(*) as TypeCount 
                           FROM books 
                           WHERE date_delete IS NULL
                           GROUP BY book_type";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int totalBookTypes = 0;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            chart1.Series.Clear();
                            chart1.Titles.Clear();
                            Series series = new Series();
                            series.ChartType = SeriesChartType.Pie;

                            while (reader.Read())
                            {
                                string bookType = reader["book_type"].ToString();
                                int count = Convert.ToInt32(reader["TypeCount"]);
                                series.Points.AddXY(bookType, count);
                                totalBookTypes++; 
                            }

                            dashboard_BT.Text = totalBookTypes.ToString();

                            chart1.Series.Add(series);
                            chart1.Titles.Add("Pasta Grafiği");
                            series.Label = "#PERCENT{P1}";
                            series.LegendText = "#VALX";
                            chart1.BackColor = System.Drawing.Color.Transparent;
                            chart1.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
                            chart1.Legends[0].BackColor = System.Drawing.Color.Transparent;
                            chart1.Legends[0].Docking = Docking.Right;

                            chart1.Invalidate();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void verigoster_buton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string typeQuery = @"
                SELECT TOP 1 book_type, COUNT(*) as BorrowCount 
                FROM issues
                WHERE MONTH(issue_date) = MONTH(GETDATE()) 
                  AND YEAR(issue_date) = YEAR(GETDATE())
                GROUP BY book_type
                ORDER BY BorrowCount DESC";

                    string titleQuery = @"
                SELECT TOP 1 book_title, COUNT(*) as BorrowCount 
                FROM issues
                WHERE MONTH(issue_date) = MONTH(GETDATE()) 
                  AND YEAR(issue_date) = YEAR(GETDATE())
                GROUP BY book_title
                ORDER BY BorrowCount DESC";

                    listBox1.Items.Clear();

                    using (SqlCommand cmd = new SqlCommand(typeQuery, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string mostBorrowedType = reader["book_type"].ToString();
                                int typeCount = Convert.ToInt32(reader["BorrowCount"]);

                                listBox1.Items.Add($"Bu ayın en çok ödünç alınan türü: {mostBorrowedType}");
                                listBox1.Items.Add($"Tür ödünç alınma sayısı: {typeCount}");
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(titleQuery, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string mostBorrowedTitle = reader["book_title"].ToString();
                                int titleCount = Convert.ToInt32(reader["BorrowCount"]);

                                listBox1.Items.Add($"Bu ayın en çok alınan kitabı: {mostBorrowedTitle}");
                                listBox1.Items.Add($"Kitap ödünç alınma sayısı: {titleCount}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void veritemizle_buton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
