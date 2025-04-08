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
    public partial class IssueBooks : UserControl
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-67F8JG8\SQLEXPRESS;Initial Catalog=Kütüphane_Yönetim;Integrated Security=True;TrustServerCertificate=True");
        public IssueBooks()
        {
            InitializeComponent();

            displayBookIssueData();
            DataBookTitle();

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

            displayBookIssueData();
            DataBookTitle();
        }

        public void displayBookIssueData()
        {

            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.IssueBooksData();

            dataGridView1.DataSource = listData;
        }

        private void okitapekle_buton_Click(object sender, EventArgs e)
        {
            if (kitapodunc_id.Text == ""
                || kitapodunc_ad.Text == ""
                || kitapodunc_iletisim.Text == ""
                || kitapodunc_email.Text == ""
                || kitapodunc_KitapAdı.Text == ""
                || kitapodunc_yazar.Text == ""
                || kitapodunc_odtarih.Value == null
                || kitapodunc_iadetarihi.Value == null
                || bookIssue_status.Text == ""
                || comboBox1.SelectedIndex == -1
                || bookIssue_picture.Image == null)
            {
                MessageBox.Show("Lütfen tüm boş alanları doldurun", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        DateTime today = DateTime.Today;

                        connect.Open();

                        string insertData = "INSERT INTO issues " +
    "(issue_id, full_name, contact, email, book_title, book_type, author, status, issue_date, return_date, date_insert) " +
    "VALUES(@issueID, @fullname, @contact, @email, @bookTitle, @bookType, @author, @status, @issueDate, @returnDate, @dateInsert)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@issueID", kitapodunc_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullname", kitapodunc_ad.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", kitapodunc_iletisim.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", kitapodunc_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@bookTitle", kitapodunc_KitapAdı.Text.Trim());
                            cmd.Parameters.AddWithValue("@bookType", comboBox1.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@author", kitapodunc_yazar.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", bookIssue_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@issueDate", kitapodunc_odtarih.Value);
                            cmd.Parameters.AddWithValue("@returnDate", kitapodunc_iadetarihi.Value);
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBookIssueData();

                            MessageBox.Show("Başarıyla Ödünç Verildi!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void clearFields()
        {
            kitapodunc_id.Text = "";
            kitapodunc_ad.Text = "";
            kitapodunc_iletisim.Text = "";
            kitapodunc_email.Text = "";
            kitapodunc_KitapAdı.SelectedIndex = -1;
            kitapodunc_yazar.SelectedIndex = -1;
            bookIssue_status.SelectedIndex = -1;
            bookIssue_picture.Image = null;
            comboBox1.SelectedIndex = -1;
        }

        public void DataBookTitle()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, book_title FROM books WHERE status = 'Available' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        kitapodunc_KitapAdı.DataSource = table;
                        kitapodunc_KitapAdı.DisplayMember = "book_title";
                        kitapodunc_KitapAdı.ValueMember = "id";

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

        private void bookIssue_bookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (kitapodunc_KitapAdı.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)kitapodunc_KitapAdı.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM books WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                kitapodunc_yazar.Text = table.Rows[0]["author"].ToString();

                                string imagePath = table.Rows[0]["image"].ToString();

                                if (imagePath != null)
                                {
                                    bookIssue_picture.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    bookIssue_picture.Image = null;
                                }
                            }
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

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                kitapodunc_id.Text = row.Cells[1].Value.ToString();
                kitapodunc_ad.Text = row.Cells[2].Value.ToString();
                kitapodunc_iletisim.Text = row.Cells[3].Value.ToString();
                kitapodunc_email.Text = row.Cells[4].Value.ToString();
                kitapodunc_KitapAdı.Text = row.Cells[5].Value.ToString();
                kitapodunc_yazar.Text = row.Cells[6].Value.ToString();
                kitapodunc_odtarih.Text = row.Cells[7].Value.ToString();
                kitapodunc_iadetarihi.Text = row.Cells[8].Value.ToString();
                bookIssue_status.Text = row.Cells[9].Value.ToString();

            }
        }

        private void okitapguncelle_buton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(kitapodunc_id.Text)
                || string.IsNullOrWhiteSpace(kitapodunc_ad.Text)
                || string.IsNullOrWhiteSpace(kitapodunc_iletisim.Text)
                || string.IsNullOrWhiteSpace(kitapodunc_email.Text)
                || string.IsNullOrWhiteSpace(kitapodunc_KitapAdı.Text)
                || string.IsNullOrWhiteSpace(kitapodunc_yazar.Text)
                || kitapodunc_odtarih.Value == null
                || kitapodunc_iadetarihi.Value == null
                || comboBox1.SelectedIndex == -1
                || string.IsNullOrWhiteSpace(bookIssue_status.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            DialogResult check = MessageBox.Show("Güncellemek istediğinizden emin misiniz? Ödünç ID: "
                + kitapodunc_id.Text + "?", "Onaylama Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check != DialogResult.Yes)
            {
                MessageBox.Show("İptal Edildi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connect.Open();
                DateTime today = DateTime.Today;
                string updateData = @"UPDATE issues 
                SET full_name = @fullName, 
                contact = @contact, 
                email = @email, 
                book_title = @bookTitle, 
                author = @author, 
                status = @status, 
                issue_date = @issueDate, 
                return_date = @returnDate,
                book_type = @bookType,
                date_update = @dateUpdate 
                WHERE issue_id = @issueID";

                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                {
                    
                    cmd.Parameters.AddWithValue("@fullName", kitapodunc_ad.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", kitapodunc_iletisim.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", kitapodunc_email.Text.Trim());
                    cmd.Parameters.AddWithValue("@bookTitle", kitapodunc_KitapAdı.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", kitapodunc_yazar.Text.Trim());
                    cmd.Parameters.AddWithValue("@status", bookIssue_status.Text.Trim());
                    cmd.Parameters.AddWithValue("@issueDate", kitapodunc_odtarih.Value);
                    cmd.Parameters.AddWithValue("@returnDate", kitapodunc_iadetarihi.Value);
                    cmd.Parameters.AddWithValue("@dateUpdate", today);
                    cmd.Parameters.AddWithValue("@bookType", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@issueID", kitapodunc_id.Text.Trim());

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        
                        displayBookIssueData();
                        MessageBox.Show("Başarıyla Güncellendi!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme yapılamadı. Kayıt bulunamadı.", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void okitapsil_buton_Click(object sender, EventArgs e)
        {
            if (kitapodunc_id.Text == ""
                || kitapodunc_ad.Text == ""
                || kitapodunc_iletisim.Text == ""
                || kitapodunc_email.Text == ""
                || kitapodunc_KitapAdı.Text == ""
                || kitapodunc_yazar.Text == ""
                || kitapodunc_odtarih.Value == null
                || kitapodunc_iadetarihi.Value == null
                || bookIssue_status.Text == ""
                || bookIssue_picture.Image == null)
            {
                MessageBox.Show("Lütfen önce ürünü seçin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("SİLMEK istediğinizden emin misiniz? Ödünç ID:"
                        + kitapodunc_id.Text.Trim() + "?", "Onaylama Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE issues SET date_delete = @dateDelete WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@issueID", kitapodunc_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Başarıyla Silindi!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    else
                    {
                        MessageBox.Show("İptal Edildi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void okitaptemizle_buton_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
