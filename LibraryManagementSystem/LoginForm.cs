using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-67F8JG8\SQLEXPRESS;Initial Catalog=Kütüphane_Yönetim;Integrated Security=True;TrustServerCertificate=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayitol_buton_Click(object sender, EventArgs e)
        {
            RegisterForm rForm = new RegisterForm();
            rForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            kullanicisifre_girisyap.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void girisyap_buton_Click(object sender, EventArgs e)
        {
            if (kullaniciadi_girisyap.Text == "" || kullanicisifre_girisyap.Text == "")
            {
                MessageBox.Show("Lütfen tüm boş alanları doldurun", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData
                            = "SELECT * FROM users WHERE username = @username AND password = @password";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", kullaniciadi_girisyap.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", kullanicisifre_girisyap.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Başarıyla Giriş Yapıldı!", "Bilgilendirme Mesajı"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Hatalı Kullanıcı Adı / Şifre", "Hata Mesajı"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı bağlanırken hata oluştu: " + ex, "Hata Mesajı"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
