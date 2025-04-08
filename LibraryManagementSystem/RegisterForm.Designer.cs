
namespace LibraryManagementSystem
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.girisyap_buton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kayitol_buton = new System.Windows.Forms.Button();
            this.kayit_sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kayit_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kayit_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPass.Location = new System.Drawing.Point(183, 364);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(103, 20);
            this.register_showPass.TabIndex = 21;
            this.register_showPass.Text = "Şifreyi Göster";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // girisyap_buton
            // 
            this.girisyap_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.girisyap_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisyap_buton.FlatAppearance.BorderSize = 0;
            this.girisyap_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.girisyap_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.girisyap_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisyap_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisyap_buton.ForeColor = System.Drawing.Color.White;
            this.girisyap_buton.Location = new System.Drawing.Point(20, 489);
            this.girisyap_buton.Name = "girisyap_buton";
            this.girisyap_buton.Size = new System.Drawing.Size(281, 30);
            this.girisyap_buton.TabIndex = 20;
            this.girisyap_buton.Text = "GİRİŞ YAP";
            this.girisyap_buton.UseVisualStyleBackColor = false;
            this.girisyap_buton.Click += new System.EventHandler(this.girisyap_buton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hesap Açın";
            // 
            // kayitol_buton
            // 
            this.kayitol_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.kayitol_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitol_buton.FlatAppearance.BorderSize = 0;
            this.kayitol_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.kayitol_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.kayitol_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitol_buton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitol_buton.ForeColor = System.Drawing.Color.White;
            this.kayitol_buton.Location = new System.Drawing.Point(20, 410);
            this.kayitol_buton.Name = "kayitol_buton";
            this.kayitol_buton.Size = new System.Drawing.Size(281, 40);
            this.kayitol_buton.TabIndex = 18;
            this.kayitol_buton.Text = "KAYIT OL";
            this.kayitol_buton.UseVisualStyleBackColor = false;
            this.kayitol_buton.Click += new System.EventHandler(this.kayitol_buton_Click);
            // 
            // kayit_sifre
            // 
            this.kayit_sifre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_sifre.Location = new System.Drawing.Point(20, 328);
            this.kayit_sifre.Multiline = true;
            this.kayit_sifre.Name = "kayit_sifre";
            this.kayit_sifre.PasswordChar = '*';
            this.kayit_sifre.Size = new System.Drawing.Size(281, 30);
            this.kayit_sifre.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Şifre:";
            // 
            // kayit_kullaniciadi
            // 
            this.kayit_kullaniciadi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_kullaniciadi.Location = new System.Drawing.Point(19, 268);
            this.kayit_kullaniciadi.Multiline = true;
            this.kayit_kullaniciadi.Name = "kayit_kullaniciadi";
            this.kayit_kullaniciadi.Size = new System.Drawing.Size(281, 30);
            this.kayit_kullaniciadi.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kayıt Formu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icons8_library_100px;
            this.pictureBox1.Location = new System.Drawing.Point(107, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 35);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kayit_email
            // 
            this.kayit_email.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_email.Location = new System.Drawing.Point(19, 210);
            this.kayit_email.Multiline = true;
            this.kayit_email.Name = "kayit_email";
            this.kayit_email.Size = new System.Drawing.Size(281, 30);
            this.kayit_email.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email Adresi:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 525);
            this.Controls.Add(this.kayit_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.girisyap_buton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kayitol_buton);
            this.Controls.Add(this.kayit_sifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kayit_kullaniciadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.Button girisyap_buton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kayitol_buton;
        private System.Windows.Forms.TextBox kayit_sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kayit_kullaniciadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kayit_email;
        private System.Windows.Forms.Label label6;
    }
}