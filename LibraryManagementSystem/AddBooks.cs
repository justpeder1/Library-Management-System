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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class AddBooks : UserControl
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-67F8JG8\SQLEXPRESS;Initial Catalog=Kütüphane_Yönetim;Integrated Security=True;TrustServerCertificate=True");

        public AddBooks()
        {
            InitializeComponent();

            displayBooks();

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

            displayBooks();
        }

        private String imagePath;

        private void kitapekle_resim_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addBooks_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kitapekle_buton_Click(object sender, EventArgs e)
        {
            if (addBooks_picture.Image == null
               || kitapekle_kitapadi.Text == ""
               || kitapekle_yazar.Text == ""
               || kitapekle_yayinlanma.Value == null
               || addBooks_status.Text == ""
               || comboBox1.SelectedIndex == -1
               || addBooks_picture.Image == null)
            {
                MessageBox.Show("Lütfen tüm boş alanları doldurun", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        connect.Open();
                        string insertData = "INSERT INTO books " +
                            "(book_title, author, published_date, status, book_type, image, date_insert) " +
                            "VALUES(@bookTitle, @author, @published_date, @status, @bookType, @image, @dateInsert)";

                        string path = Path.Combine(@"D:\Library-Management-System-using-CSharp-main\LibraryManagementSystem\LibraryManagementSystem\Books_Directory" +
                            kitapekle_kitapadi.Text + kitapekle_yazar.Text.Trim() + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        File.Copy(addBooks_picture.ImageLocation, path, true);

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookTitle", kitapekle_kitapadi.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", kitapekle_yazar.Text.Trim());
                            cmd.Parameters.AddWithValue("@published_date", kitapekle_yayinlanma.Value);
                            cmd.Parameters.AddWithValue("@status", addBooks_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@bookType", comboBox1.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBooks();

                            MessageBox.Show("Başarıyla Eklendi!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            kitapekle_kitapadi.Text = "";
            kitapekle_yazar.Text = "";
            addBooks_picture.Image = null;
            addBooks_status.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List<DataAddBooks> listData = dab.addBooksData();

            dataGridView1.DataSource = listData;

        }

        private int bookID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookID = (int)row.Cells[0].Value;
                kitapekle_kitapadi.Text = row.Cells[1].Value.ToString();
                kitapekle_yazar.Text = row.Cells[2].Value.ToString();
                kitapekle_yayinlanma.Text = row.Cells[3].Value.ToString();

                string imagePath = row.Cells[4].Value.ToString();


                if (imagePath != null || imagePath.Length >= 1)
                {
                    addBooks_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addBooks_picture.Image = null;
                }
                addBooks_status.Text = row.Cells[5].Value.ToString();
            }
        }

        private void kitaptemizle_buton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void kitapguncelle_buton_Click(object sender, EventArgs e)
        {
           if (addBooks_picture.Image == null
                || kitapekle_kitapadi.Text == ""
                || kitapekle_yazar.Text == ""
                || kitapekle_yayinlanma.Value == null
                || addBooks_status.Text == ""
                || comboBox1.SelectedIndex == -1
                || addBooks_picture.Image == null)
            {
                MessageBox.Show("Lütfen önce ürünü seçin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Güncellemek istediğinizden emin misiniz? Kitap ID:"
                        + bookID + "?", "Onaylama Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET book_title = @bookTitle" +
                                ", author = @author, published_date = @published" +
                                ", status = @status, book_type = @bookType" +
                                ", date_update = @dateUpdate WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@bookTitle", kitapekle_kitapadi.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", kitapekle_yazar.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", kitapekle_yayinlanma.Value);
                                cmd.Parameters.AddWithValue("@status", addBooks_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@bookType", comboBox1.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Başarıyla güncellendi!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void kitapsil_buton_Click(object sender, EventArgs e)
        {
            if (addBooks_picture.Image == null
                || kitapekle_kitapadi.Text == ""
                || kitapekle_yazar.Text == ""
                || kitapekle_yayinlanma.Value == null
                || addBooks_status.Text == ""
                || addBooks_picture.Image == null)
            {
                MessageBox.Show("Lütfen önce ürünü seçin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("SİLMEK istediğinizden emin misiniz? Kitap ID:"
                        + bookID + "?", "Onaylama Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET date_delete = @dateDelete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

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
    }
}
