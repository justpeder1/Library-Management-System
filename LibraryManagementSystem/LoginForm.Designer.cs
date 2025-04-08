
namespace LibraryManagementSystem
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciadi_girisyap = new System.Windows.Forms.TextBox();
            this.kullanicisifre_girisyap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.girisyap_buton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kayitol_buton = new System.Windows.Forms.Button();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 35);
            this.panel1.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Merhaba, Kullanıcı!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // kullaniciadi_girisyap
            // 
            this.kullaniciadi_girisyap.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciadi_girisyap.Location = new System.Drawing.Point(20, 238);
            this.kullaniciadi_girisyap.Multiline = true;
            this.kullaniciadi_girisyap.Name = "kullaniciadi_girisyap";
            this.kullaniciadi_girisyap.Size = new System.Drawing.Size(281, 30);
            this.kullaniciadi_girisyap.TabIndex = 4;
            // 
            // kullanicisifre_girisyap
            // 
            this.kullanicisifre_girisyap.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanicisifre_girisyap.Location = new System.Drawing.Point(20, 307);
            this.kullanicisifre_girisyap.Multiline = true;
            this.kullanicisifre_girisyap.Name = "kullanicisifre_girisyap";
            this.kullanicisifre_girisyap.PasswordChar = '*';
            this.kullanicisifre_girisyap.Size = new System.Drawing.Size(281, 30);
            this.kullanicisifre_girisyap.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre:";
            // 
            // girisyap_buton
            // 
            this.girisyap_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.girisyap_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisyap_buton.FlatAppearance.BorderSize = 0;
            this.girisyap_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.girisyap_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.girisyap_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisyap_buton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisyap_buton.ForeColor = System.Drawing.Color.White;
            this.girisyap_buton.Location = new System.Drawing.Point(20, 380);
            this.girisyap_buton.Name = "girisyap_buton";
            this.girisyap_buton.Size = new System.Drawing.Size(281, 40);
            this.girisyap_buton.TabIndex = 7;
            this.girisyap_buton.Text = "GİRİŞ YAP";
            this.girisyap_buton.UseVisualStyleBackColor = false;
            this.girisyap_buton.Click += new System.EventHandler(this.girisyap_buton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 8;
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
            this.kayitol_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitol_buton.ForeColor = System.Drawing.Color.White;
            this.kayitol_buton.Location = new System.Drawing.Point(20, 483);
            this.kayitol_buton.Name = "kayitol_buton";
            this.kayitol_buton.Size = new System.Drawing.Size(281, 30);
            this.kayitol_buton.TabIndex = 9;
            this.kayitol_buton.Text = "KAYIT OL";
            this.kayitol_buton.UseVisualStyleBackColor = false;
            this.kayitol_buton.Click += new System.EventHandler(this.kayitol_buton_Click);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPass.Location = new System.Drawing.Point(183, 343);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(103, 20);
            this.login_showPass.TabIndex = 10;
            this.login_showPass.Text = "Şifreyi Göster";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icons8_library_100px;
            this.pictureBox1.Location = new System.Drawing.Point(105, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 525);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.kayitol_buton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.girisyap_buton);
            this.Controls.Add(this.kullanicisifre_girisyap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kullaniciadi_girisyap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullaniciadi_girisyap;
        private System.Windows.Forms.TextBox kullanicisifre_girisyap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button girisyap_buton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kayitol_buton;
        private System.Windows.Forms.CheckBox login_showPass;
    }
}