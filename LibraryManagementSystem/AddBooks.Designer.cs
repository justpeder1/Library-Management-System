
namespace LibraryManagementSystem
{
    partial class AddBooks
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kitapekle_resim = new System.Windows.Forms.Button();
            this.kitaptemizle_buton = new System.Windows.Forms.Button();
            this.kitapsil_buton = new System.Windows.Forms.Button();
            this.addBooks_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kitapekle_yayinlanma = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.kitapguncelle_buton = new System.Windows.Forms.Button();
            this.kitapekle_buton = new System.Windows.Forms.Button();
            this.kitapekle_yazar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kitapekle_kitapadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addBooks_picture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(313, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 526);
            this.panel2.TabIndex = 3;
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 58);
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
            this.dataGridView1.Size = new System.Drawing.Size(521, 447);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut Kitaplar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.kitapekle_resim);
            this.panel1.Controls.Add(this.kitaptemizle_buton);
            this.panel1.Controls.Add(this.kitapsil_buton);
            this.panel1.Controls.Add(this.addBooks_status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.kitapekle_yayinlanma);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kitapguncelle_buton);
            this.panel1.Controls.Add(this.kitapekle_buton);
            this.panel1.Controls.Add(this.kitapekle_yazar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.kitapekle_kitapadi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addBooks_picture);
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 526);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kitap Türü:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kitapekle_resim
            // 
            this.kitapekle_resim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.kitapekle_resim.FlatAppearance.BorderSize = 0;
            this.kitapekle_resim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapekle_resim.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapekle_resim.ForeColor = System.Drawing.Color.White;
            this.kitapekle_resim.Location = new System.Drawing.Point(90, 115);
            this.kitapekle_resim.Name = "kitapekle_resim";
            this.kitapekle_resim.Size = new System.Drawing.Size(100, 23);
            this.kitapekle_resim.TabIndex = 23;
            this.kitapekle_resim.Text = "Resim Ekle";
            this.kitapekle_resim.UseVisualStyleBackColor = false;
            this.kitapekle_resim.Click += new System.EventHandler(this.kitapekle_resim_Click);
            // 
            // kitaptemizle_buton
            // 
            this.kitaptemizle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.kitaptemizle_buton.FlatAppearance.BorderSize = 0;
            this.kitaptemizle_buton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitaptemizle_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitaptemizle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitaptemizle_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitaptemizle_buton.ForeColor = System.Drawing.Color.White;
            this.kitaptemizle_buton.Location = new System.Drawing.Point(146, 406);
            this.kitaptemizle_buton.Name = "kitaptemizle_buton";
            this.kitaptemizle_buton.Size = new System.Drawing.Size(99, 34);
            this.kitaptemizle_buton.TabIndex = 22;
            this.kitaptemizle_buton.Text = "TEMİZLE";
            this.kitaptemizle_buton.UseVisualStyleBackColor = false;
            this.kitaptemizle_buton.Click += new System.EventHandler(this.kitaptemizle_buton_Click);
            // 
            // kitapsil_buton
            // 
            this.kitapsil_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.kitapsil_buton.FlatAppearance.BorderSize = 0;
            this.kitapsil_buton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapsil_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapsil_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapsil_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapsil_buton.ForeColor = System.Drawing.Color.White;
            this.kitapsil_buton.Location = new System.Drawing.Point(27, 406);
            this.kitapsil_buton.Name = "kitapsil_buton";
            this.kitapsil_buton.Size = new System.Drawing.Size(99, 34);
            this.kitapsil_buton.TabIndex = 21;
            this.kitapsil_buton.Text = "SİL";
            this.kitapsil_buton.UseVisualStyleBackColor = false;
            this.kitapsil_buton.Click += new System.EventHandler(this.kitapsil_buton_Click);
            // 
            // addBooks_status
            // 
            this.addBooks_status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_status.FormattingEnabled = true;
            this.addBooks_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addBooks_status.Location = new System.Drawing.Point(95, 261);
            this.addBooks_status.Name = "addBooks_status";
            this.addBooks_status.Size = new System.Drawing.Size(168, 24);
            this.addBooks_status.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Durum:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kitapekle_yayinlanma
            // 
            this.kitapekle_yayinlanma.Location = new System.Drawing.Point(94, 228);
            this.kitapekle_yayinlanma.Name = "kitapekle_yayinlanma";
            this.kitapekle_yayinlanma.Size = new System.Drawing.Size(167, 20);
            this.kitapekle_yayinlanma.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yayınlanma:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kitapguncelle_buton
            // 
            this.kitapguncelle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.kitapguncelle_buton.FlatAppearance.BorderSize = 0;
            this.kitapguncelle_buton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapguncelle_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapguncelle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapguncelle_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapguncelle_buton.ForeColor = System.Drawing.Color.White;
            this.kitapguncelle_buton.Location = new System.Drawing.Point(146, 354);
            this.kitapguncelle_buton.Name = "kitapguncelle_buton";
            this.kitapguncelle_buton.Size = new System.Drawing.Size(99, 34);
            this.kitapguncelle_buton.TabIndex = 16;
            this.kitapguncelle_buton.Text = "GÜNCELLE";
            this.kitapguncelle_buton.UseVisualStyleBackColor = false;
            this.kitapguncelle_buton.Click += new System.EventHandler(this.kitapguncelle_buton_Click);
            // 
            // kitapekle_buton
            // 
            this.kitapekle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.kitapekle_buton.FlatAppearance.BorderSize = 0;
            this.kitapekle_buton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapekle_buton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.kitapekle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapekle_buton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapekle_buton.ForeColor = System.Drawing.Color.White;
            this.kitapekle_buton.Location = new System.Drawing.Point(27, 354);
            this.kitapekle_buton.Name = "kitapekle_buton";
            this.kitapekle_buton.Size = new System.Drawing.Size(99, 34);
            this.kitapekle_buton.TabIndex = 15;
            this.kitapekle_buton.Text = "EKLE";
            this.kitapekle_buton.UseVisualStyleBackColor = false;
            this.kitapekle_buton.Click += new System.EventHandler(this.kitapekle_buton_Click);
            // 
            // kitapekle_yazar
            // 
            this.kitapekle_yazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapekle_yazar.Location = new System.Drawing.Point(95, 187);
            this.kitapekle_yazar.Name = "kitapekle_yazar";
            this.kitapekle_yazar.Size = new System.Drawing.Size(168, 22);
            this.kitapekle_yazar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Yazar:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kitapekle_kitapadi
            // 
            this.kitapekle_kitapadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapekle_kitapadi.Location = new System.Drawing.Point(95, 149);
            this.kitapekle_kitapadi.Name = "kitapekle_kitapadi";
            this.kitapekle_kitapadi.Size = new System.Drawing.Size(168, 22);
            this.kitapekle_kitapadi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kitap Adı:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBooks_picture
            // 
            this.addBooks_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addBooks_picture.Location = new System.Drawing.Point(90, 18);
            this.addBooks_picture.Name = "addBooks_picture";
            this.addBooks_picture.Size = new System.Drawing.Size(100, 100);
            this.addBooks_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBooks_picture.TabIndex = 8;
            this.addBooks_picture.TabStop = false;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBooks";
            this.Size = new System.Drawing.Size(880, 565);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kitapguncelle_buton;
        private System.Windows.Forms.Button kitapekle_buton;
        private System.Windows.Forms.TextBox kitapekle_yazar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kitapekle_kitapadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox addBooks_picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker kitapekle_yayinlanma;
        private System.Windows.Forms.ComboBox addBooks_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kitaptemizle_buton;
        private System.Windows.Forms.Button kitapsil_buton;
        private System.Windows.Forms.Button kitapekle_resim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}
