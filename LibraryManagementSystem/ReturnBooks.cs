using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-67F8JG8\SQLEXPRESS;Initial Catalog=Kütüphane_Yönetim;Integrated Security=True;TrustServerCertificate=True");

        public ReturnBooks()
        {
            InitializeComponent();

            InitializeComboBox();
            displayIssuedBooksData();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(new string[] {
                "Roman",
                "Öykü",
                "Şiir",
                "Tarih",
                "Bilim",
                "Felsefe",
                "Biyografi",
                "Psikoloji",
                "Çocuk Kitapları",
                "Bilim Kurgu",
                "Fantastik",
                "Polisiye",
                "Macera",
                "Eğitim"
            });           
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIssuedBooksData();
        }

        private void kitapiade_buton_Click(object sender, EventArgs e)
        {
            if (Okitap_id.Text == ""
                || Okitap_Adi.Text == ""
                || Okitap_iletisim.Text == ""
                || Okitap_email.Text == ""
                || Okitap_kitapadi.Text == ""
                || Okitap_yazar.Text == ""
                || bookIssue_issueDate.Value == null)
            {
                MessageBox.Show("Lütfen önce ürünü seçin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    DialogResult check = MessageBox.Show("Emin misiniz ? Ödünç ID: "
                        + Okitap_id.Text.Trim()
                        + "zaten iade edildi?", "Onaylama Mesajı", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            connect.Open();

                            string updateData = "UPDATE issues SET status = @status, date_update = @dateUpdate " +
                                "WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@status", "Return");
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", Okitap_id.Text);

                                cmd.ExecuteNonQuery();

                                displayIssuedBooksData();

                                MessageBox.Show("Başarıyla iade edildi!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        public void displayIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.ReturnIssueBooksData();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Okitap_id.Text = row.Cells[1].Value.ToString();
                Okitap_Adi.Text = row.Cells[2].Value.ToString();
                Okitap_iletisim.Text = row.Cells[3].Value.ToString();
                Okitap_email.Text = row.Cells[4].Value.ToString();
                Okitap_kitapadi.Text = row.Cells[5].Value.ToString();
                Okitap_yazar.Text = row.Cells[6].Value.ToString();
                bookIssue_issueDate.Text = row.Cells[7].Value.ToString();
            }
        }

        public void clearFields()
        {
            Okitap_id.Text = "";
            Okitap_Adi.Text = "";
            Okitap_iletisim.Text = "";
            Okitap_email.Text = "";
            Okitap_kitapadi.Text = "";
            Okitap_yazar.Text = "";
        }

        private void kitapiadetemizle_buton_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}