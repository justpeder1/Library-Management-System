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
    public partial class RegisterForm : Form
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-67F8JG8\SQLEXPRESS;Initial Catalog=Kütüphane_Yönetim;Integrated Security=True;TrustServerCertificate=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void girisyap_buton_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayitol_buton_Click(object sender, EventArgs e)
        {
            if (kayit_email.Text == "" || kayit_kullaniciadi.Text == "" || kayit_sifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm boş alanları doldurunuz", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String checkUsername = "SELECT COUNT(*) FROM users WHERE username = @username";

                        using (SqlCommand checkCMD = new SqlCommand(checkUsername, connect))
                        {
                            checkCMD.Parameters.AddWithValue("@username", kayit_kullaniciadi.Text.Trim());
                            int count = (int)checkCMD.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(kayit_kullaniciadi.Text.Trim()
                                    + " zaten alınmış", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                
                                DateTime day = DateTime.Today;

                                String insertData = "INSERT INTO users (email, username, password, date_register) " +
                                    "VALUES(@email, @username, @password, @date)";

                                using (SqlCommand insertCMD = new SqlCommand(insertData, connect))
                                {
                                    insertCMD.Parameters.AddWithValue("@email", kayit_email.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@username", kayit_kullaniciadi.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@password", kayit_sifre.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@date", day);

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Başarıyla kayıt oldu!", "Bilgilendirme Mesajı"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm lForm = new LoginForm();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı bağlanırken hata oluştu: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            kayit_sifre.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }       
    }
}
