
namespace LibraryManagementSystem
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kitaptur_buton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cikisyap_buton = new System.Windows.Forms.Button();
            this.kitapiade_buton = new System.Windows.Forms.Button();
            this.kitapodunc_buton = new System.Windows.Forms.Button();
            this.kitapekle_buton = new System.Windows.Forms.Button();
            this.gösterge_buton = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.booksType1 = new LibraryManagementSystem.BooksType();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.issueBooks1 = new LibraryManagementSystem.IssueBooks();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kütüphane Yönetim Sistemi | Ana Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1082, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.kitaptur_buton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cikisyap_buton);
            this.panel2.Controls.Add(this.kitapiade_buton);
            this.panel2.Controls.Add(this.kitapodunc_buton);
            this.panel2.Controls.Add(this.kitapekle_buton);
            this.panel2.Controls.Add(this.gösterge_buton);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 565);
            this.panel2.TabIndex = 1;
            // 
            // kitaptur_buton
            // 
            this.kitaptur_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitaptur_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitaptur_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitaptur_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitaptur_buton.ForeColor = System.Drawing.Color.White;
            this.kitaptur_buton.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px_1;
            this.kitaptur_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitaptur_buton.Location = new System.Drawing.Point(8, 389);
            this.kitaptur_buton.Name = "kitaptur_buton";
            this.kitaptur_buton.Size = new System.Drawing.Size(200, 45);
            this.kitaptur_buton.TabIndex = 8;
            this.kitaptur_buton.Text = "KİTAP TÜRLERİ";
            this.kitaptur_buton.UseVisualStyleBackColor = true;
            this.kitaptur_buton.Click += new System.EventHandler(this.kitaptur_buton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Çıkış Yap";
            // 
            // cikisyap_buton
            // 
            this.cikisyap_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisyap_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cikisyap_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cikisyap_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisyap_buton.ForeColor = System.Drawing.Color.White;
            this.cikisyap_buton.Image = global::LibraryManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_20px;
            this.cikisyap_buton.Location = new System.Drawing.Point(8, 522);
            this.cikisyap_buton.Name = "cikisyap_buton";
            this.cikisyap_buton.Size = new System.Drawing.Size(35, 35);
            this.cikisyap_buton.TabIndex = 6;
            this.cikisyap_buton.UseVisualStyleBackColor = true;
            this.cikisyap_buton.Click += new System.EventHandler(this.cikisyap_buton_Click);
            // 
            // kitapiade_buton
            // 
            this.kitapiade_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapiade_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapiade_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapiade_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapiade_buton.ForeColor = System.Drawing.Color.White;
            this.kitapiade_buton.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_32px_3;
            this.kitapiade_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapiade_buton.Location = new System.Drawing.Point(8, 338);
            this.kitapiade_buton.Name = "kitapiade_buton";
            this.kitapiade_buton.Size = new System.Drawing.Size(200, 45);
            this.kitapiade_buton.TabIndex = 5;
            this.kitapiade_buton.Text = "İADE KİTAPLAR";
            this.kitapiade_buton.UseVisualStyleBackColor = true;
            this.kitapiade_buton.Click += new System.EventHandler(this.kitapiade_buton_Click);
            // 
            // kitapodunc_buton
            // 
            this.kitapodunc_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapodunc_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapodunc_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapodunc_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapodunc_buton.ForeColor = System.Drawing.Color.White;
            this.kitapodunc_buton.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px_1;
            this.kitapodunc_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapodunc_buton.Location = new System.Drawing.Point(8, 287);
            this.kitapodunc_buton.Name = "kitapodunc_buton";
            this.kitapodunc_buton.Size = new System.Drawing.Size(200, 45);
            this.kitapodunc_buton.TabIndex = 4;
            this.kitapodunc_buton.Text = "ÖDÜNÇ KİTAPLAR";
            this.kitapodunc_buton.UseVisualStyleBackColor = true;
            this.kitapodunc_buton.Click += new System.EventHandler(this.kitapodunc_buton_Click);
            // 
            // kitapekle_buton
            // 
            this.kitapekle_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapekle_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapekle_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapekle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapekle_buton.ForeColor = System.Drawing.Color.White;
            this.kitapekle_buton.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px;
            this.kitapekle_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapekle_buton.Location = new System.Drawing.Point(8, 236);
            this.kitapekle_buton.Name = "kitapekle_buton";
            this.kitapekle_buton.Size = new System.Drawing.Size(200, 45);
            this.kitapekle_buton.TabIndex = 3;
            this.kitapekle_buton.Text = "KİTAP EKLE";
            this.kitapekle_buton.UseVisualStyleBackColor = true;
            this.kitapekle_buton.Click += new System.EventHandler(this.kitapekle_buton_Click);
            // 
            // gösterge_buton
            // 
            this.gösterge_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gösterge_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.gösterge_buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.gösterge_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gösterge_buton.ForeColor = System.Drawing.Color.White;
            this.gösterge_buton.Image = global::LibraryManagementSystem.Properties.Resources.icons8_dashboard_32px;
            this.gösterge_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gösterge_buton.Location = new System.Drawing.Point(8, 185);
            this.gösterge_buton.Name = "gösterge_buton";
            this.gösterge_buton.Size = new System.Drawing.Size(200, 45);
            this.gösterge_buton.TabIndex = 2;
            this.gösterge_buton.Text = "GÖSTERGE";
            this.gösterge_buton.UseVisualStyleBackColor = true;
            this.gösterge_buton.Click += new System.EventHandler(this.gösterge_buton_Click);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(41, 131);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(141, 19);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Hoşgeldin , Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icons8_library_100px;
            this.pictureBox1.Location = new System.Drawing.Point(58, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.booksType1);
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addBooks1);
            this.panel3.Controls.Add(this.issueBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Location = new System.Drawing.Point(220, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 565);
            this.panel3.TabIndex = 2;
            // 
            // booksType1
            // 
            this.booksType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksType1.Location = new System.Drawing.Point(0, 0);
            this.booksType1.Name = "booksType1";
            this.booksType1.Size = new System.Drawing.Size(880, 565);
            this.booksType1.TabIndex = 7;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(880, 565);
            this.dashboard1.TabIndex = 3;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, 0);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(880, 565);
            this.addBooks1.TabIndex = 2;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(880, 565);
            this.issueBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(880, 565);
            this.returnBooks1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kitapekle_buton;
        private System.Windows.Forms.Button gösterge_buton;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kitapiade_buton;
        private System.Windows.Forms.Button kitapodunc_buton;
        private System.Windows.Forms.Button cikisyap_buton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private ReturnBooks returnBooks1;
        private Dashboard dashboard1;
        private AddBooks addBooks1;
        private IssueBooks issueBooks1;
        private BooksType booksType1;
        private System.Windows.Forms.Button kitaptur_buton;
    }
}