
namespace LibraryManagementSystem
{
    partial class IssueBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookIssue_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.okitaptemizle_buton = new System.Windows.Forms.Button();
            this.okitapsil_buton = new System.Windows.Forms.Button();
            this.okitapguncelle_buton = new System.Windows.Forms.Button();
            this.okitapekle_buton = new System.Windows.Forms.Button();
            this.kitapodunc_iadetarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.kitapodunc_odtarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.bookIssue_picture = new System.Windows.Forms.PictureBox();
            this.kitapodunc_yazar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kitapodunc_KitapAdı = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kitapodunc_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kitapodunc_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kitapodunc_iletisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kitapodunc_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssue_picture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.bookIssue_status);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.okitaptemizle_buton);
            this.panel1.Controls.Add(this.okitapsil_buton);
            this.panel1.Controls.Add(this.okitapguncelle_buton);
            this.panel1.Controls.Add(this.okitapekle_buton);
            this.panel1.Controls.Add(this.kitapodunc_iadetarihi);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.kitapodunc_odtarih);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bookIssue_picture);
            this.panel1.Controls.Add(this.kitapodunc_yazar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.kitapodunc_KitapAdı);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.kitapodunc_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.kitapodunc_email);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.kitapodunc_iletisim);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.kitapodunc_ad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(18, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 206);
            this.panel1.TabIndex = 0;
            // 
            // bookIssue_status
            // 
            this.bookIssue_status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_status.FormattingEnabled = true;
            this.bookIssue_status.Items.AddRange(new object[] {
            "Return",
            "Not Return"});
            this.bookIssue_status.Location = new System.Drawing.Point(567, 15);
            this.bookIssue_status.Name = "bookIssue_status";
            this.bookIssue_status.Size = new System.Drawing.Size(137, 24);
            this.bookIssue_status.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(512, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Durum:";
            // 
            // okitaptemizle_buton
            // 
            this.okitaptemizle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.okitaptemizle_buton.FlatAppearance.BorderSize = 0;
            this.okitaptemizle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okitaptemizle_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okitaptemizle_buton.ForeColor = System.Drawing.Color.White;
            this.okitaptemizle_buton.Location = new System.Drawing.Point(530, 158);
            this.okitaptemizle_buton.Name = "okitaptemizle_buton";
            this.okitaptemizle_buton.Size = new System.Drawing.Size(100, 33);
            this.okitaptemizle_buton.TabIndex = 20;
            this.okitaptemizle_buton.Text = "TEMİZLE";
            this.okitaptemizle_buton.UseVisualStyleBackColor = false;
            this.okitaptemizle_buton.Click += new System.EventHandler(this.okitaptemizle_buton_Click);
            // 
            // okitapsil_buton
            // 
            this.okitapsil_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.okitapsil_buton.FlatAppearance.BorderSize = 0;
            this.okitapsil_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okitapsil_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okitapsil_buton.ForeColor = System.Drawing.Color.White;
            this.okitapsil_buton.Location = new System.Drawing.Point(412, 158);
            this.okitapsil_buton.Name = "okitapsil_buton";
            this.okitapsil_buton.Size = new System.Drawing.Size(100, 33);
            this.okitapsil_buton.TabIndex = 19;
            this.okitapsil_buton.Text = "SİL";
            this.okitapsil_buton.UseVisualStyleBackColor = false;
            this.okitapsil_buton.Click += new System.EventHandler(this.okitapsil_buton_Click);
            // 
            // okitapguncelle_buton
            // 
            this.okitapguncelle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.okitapguncelle_buton.FlatAppearance.BorderSize = 0;
            this.okitapguncelle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okitapguncelle_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okitapguncelle_buton.ForeColor = System.Drawing.Color.White;
            this.okitapguncelle_buton.Location = new System.Drawing.Point(282, 158);
            this.okitapguncelle_buton.Name = "okitapguncelle_buton";
            this.okitapguncelle_buton.Size = new System.Drawing.Size(100, 33);
            this.okitapguncelle_buton.TabIndex = 18;
            this.okitapguncelle_buton.Text = "GÜNCELLE";
            this.okitapguncelle_buton.UseVisualStyleBackColor = false;
            this.okitapguncelle_buton.Click += new System.EventHandler(this.okitapguncelle_buton_Click);
            // 
            // okitapekle_buton
            // 
            this.okitapekle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.okitapekle_buton.FlatAppearance.BorderSize = 0;
            this.okitapekle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okitapekle_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okitapekle_buton.ForeColor = System.Drawing.Color.White;
            this.okitapekle_buton.Location = new System.Drawing.Point(164, 158);
            this.okitapekle_buton.Name = "okitapekle_buton";
            this.okitapekle_buton.Size = new System.Drawing.Size(100, 33);
            this.okitapekle_buton.TabIndex = 17;
            this.okitapekle_buton.Text = "EKLE";
            this.okitapekle_buton.UseVisualStyleBackColor = false;
            this.okitapekle_buton.Click += new System.EventHandler(this.okitapekle_buton_Click);
            // 
            // kitapodunc_iadetarihi
            // 
            this.kitapodunc_iadetarihi.Location = new System.Drawing.Point(346, 116);
            this.kitapodunc_iadetarihi.Name = "kitapodunc_iadetarihi";
            this.kitapodunc_iadetarihi.Size = new System.Drawing.Size(194, 20);
            this.kitapodunc_iadetarihi.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "İade:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kitapodunc_odtarih
            // 
            this.kitapodunc_odtarih.Location = new System.Drawing.Point(346, 83);
            this.kitapodunc_odtarih.Name = "kitapodunc_odtarih";
            this.kitapodunc_odtarih.Size = new System.Drawing.Size(194, 20);
            this.kitapodunc_odtarih.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ödünç:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookIssue_picture
            // 
            this.bookIssue_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bookIssue_picture.Location = new System.Drawing.Point(724, 15);
            this.bookIssue_picture.Name = "bookIssue_picture";
            this.bookIssue_picture.Size = new System.Drawing.Size(100, 100);
            this.bookIssue_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookIssue_picture.TabIndex = 12;
            this.bookIssue_picture.TabStop = false;
            // 
            // kitapodunc_yazar
            // 
            this.kitapodunc_yazar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapodunc_yazar.FormattingEnabled = true;
            this.kitapodunc_yazar.Location = new System.Drawing.Point(346, 48);
            this.kitapodunc_yazar.Name = "kitapodunc_yazar";
            this.kitapodunc_yazar.Size = new System.Drawing.Size(137, 24);
            this.kitapodunc_yazar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yazar:";
            // 
            // kitapodunc_KitapAdı
            // 
            this.kitapodunc_KitapAdı.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapodunc_KitapAdı.FormattingEnabled = true;
            this.kitapodunc_KitapAdı.Location = new System.Drawing.Point(346, 14);
            this.kitapodunc_KitapAdı.Name = "kitapodunc_KitapAdı";
            this.kitapodunc_KitapAdı.Size = new System.Drawing.Size(137, 24);
            this.kitapodunc_KitapAdı.TabIndex = 9;
            this.kitapodunc_KitapAdı.SelectedIndexChanged += new System.EventHandler(this.bookIssue_bookTitle_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kitap Adı:";
            // 
            // kitapodunc_id
            // 
            this.kitapodunc_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapodunc_id.Location = new System.Drawing.Point(101, 15);
            this.kitapodunc_id.Name = "kitapodunc_id";
            this.kitapodunc_id.Size = new System.Drawing.Size(145, 23);
            this.kitapodunc_id.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ödünç ID:";
            // 
            // kitapodunc_email
            // 
            this.kitapodunc_email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapodunc_email.Location = new System.Drawing.Point(101, 117);
            this.kitapodunc_email.Name = "kitapodunc_email";
            this.kitapodunc_email.Size = new System.Drawing.Size(145, 23);
            this.kitapodunc_email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // kitapodunc_iletisim
            // 
            this.kitapodunc_iletisim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapodunc_iletisim.Location = new System.Drawing.Point(102, 83);
            this.kitapodunc_iletisim.Name = "kitapodunc_iletisim";
            this.kitapodunc_iletisim.Size = new System.Drawing.Size(145, 23);
            this.kitapodunc_iletisim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İletişim #:";
            // 
            // kitapodunc_ad
            // 
            this.kitapodunc_ad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapodunc_ad.Location = new System.Drawing.Point(101, 48);
            this.kitapodunc_ad.Name = "kitapodunc_ad";
            this.kitapodunc_ad.Size = new System.Drawing.Size(145, 23);
            this.kitapodunc_ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(18, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 314);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(803, 237);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödünç Verilmiş Tüm Kitaplar";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(567, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(491, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kitap Türü:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBooks";
            this.Size = new System.Drawing.Size(880, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssue_picture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitapodunc_iletisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kitapodunc_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kitapodunc_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kitapodunc_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox kitapodunc_yazar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox kitapodunc_KitapAdı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox bookIssue_picture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker kitapodunc_iadetarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker kitapodunc_odtarih;
        private System.Windows.Forms.Button okitaptemizle_buton;
        private System.Windows.Forms.Button okitapsil_buton;
        private System.Windows.Forms.Button okitapguncelle_buton;
        private System.Windows.Forms.Button okitapekle_buton;
        private System.Windows.Forms.ComboBox bookIssue_status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
    }
}
