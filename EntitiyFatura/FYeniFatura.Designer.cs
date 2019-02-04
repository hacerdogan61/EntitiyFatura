namespace EntitiyFatura
{
    partial class FYeniFatura
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comMusteri = new System.Windows.Forms.ComboBox();
            this.comilce = new System.Windows.Forms.ComboBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comUrunAdi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblToplamFatura = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.textUrunFiyat = new System.Windows.Forms.TextBox();
            this.textUrunBirimi = new System.Windows.Forms.TextBox();
            this.textKdv = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comMusteri);
            this.groupBox1.Controls.Add(this.lblFaturaNo);
            this.groupBox1.Controls.Add(this.comilce);
            this.groupBox1.Controls.Add(this.cmbSehir);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(61, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri ve İrsaliye";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 10;
            // 
            // comMusteri
            // 
            this.comMusteri.FormattingEnabled = true;
            this.comMusteri.Location = new System.Drawing.Point(126, 133);
            this.comMusteri.Name = "comMusteri";
            this.comMusteri.Size = new System.Drawing.Size(189, 24);
            this.comMusteri.TabIndex = 9;
            // 
            // comilce
            // 
            this.comilce.FormattingEnabled = true;
            this.comilce.Location = new System.Drawing.Point(126, 103);
            this.comilce.Name = "comilce";
            this.comilce.Size = new System.Drawing.Size(189, 24);
            this.comilce.TabIndex = 8;
            this.comilce.SelectedIndexChanged += new System.EventHandler(this.comilce_SelectedIndexChanged);
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(126, 67);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(189, 24);
            this.cmbSehir.TabIndex = 7;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ödeme Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Irsaliye No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şehir";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.textKdv);
            this.groupBox2.Controls.Add(this.textUrunBirimi);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.textUrunFiyat);
            this.groupBox2.Controls.Add(this.comUrunAdi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(503, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // comUrunAdi
            // 
            this.comUrunAdi.FormattingEnabled = true;
            this.comUrunAdi.Location = new System.Drawing.Point(134, 42);
            this.comUrunAdi.Name = "comUrunAdi";
            this.comUrunAdi.Size = new System.Drawing.Size(189, 24);
            this.comUrunAdi.TabIndex = 7;
            this.comUrunAdi.SelectedIndexChanged += new System.EventHandler(this.comUrunAdi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ürün Miktarı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "KDV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ürün Birimi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ürün Fiyatı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(911, 189);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblToplamFatura
            // 
            this.lblToplamFatura.AutoSize = true;
            this.lblToplamFatura.Location = new System.Drawing.Point(691, 368);
            this.lblToplamFatura.Name = "lblToplamFatura";
            this.lblToplamFatura.Size = new System.Drawing.Size(100, 17);
            this.lblToplamFatura.TabIndex = 8;
            this.lblToplamFatura.Text = "Toplam Fatura";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(336, 237);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 35);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SIL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fatura Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(19, 34);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(71, 17);
            this.lblFaturaNo.TabIndex = 11;
            this.lblFaturaNo.Text = "Fatura No";
            // 
            // textUrunFiyat
            // 
            this.textUrunFiyat.Location = new System.Drawing.Point(134, 79);
            this.textUrunFiyat.Name = "textUrunFiyat";
            this.textUrunFiyat.Size = new System.Drawing.Size(189, 22);
            this.textUrunFiyat.TabIndex = 8;
            // 
            // textUrunBirimi
            // 
            this.textUrunBirimi.Location = new System.Drawing.Point(134, 106);
            this.textUrunBirimi.Name = "textUrunBirimi";
            this.textUrunBirimi.Size = new System.Drawing.Size(189, 22);
            this.textUrunBirimi.TabIndex = 9;
            // 
            // textKdv
            // 
            this.textKdv.Location = new System.Drawing.Point(134, 135);
            this.textKdv.Name = "textKdv";
            this.textKdv.Size = new System.Drawing.Size(189, 22);
            this.textKdv.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 172);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(189, 22);
            this.numericUpDown1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ürün Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ürün Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(991, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 60);
            this.button4.TabIndex = 13;
            this.button4.Text = "Listele Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FYeniFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 723);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblToplamFatura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FYeniFatura";
            this.Text = "FYeniFatura";
            this.Load += new System.EventHandler(this.FYeniFatura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comMusteri;
        private System.Windows.Forms.ComboBox comilce;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comUrunAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblToplamFatura;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textKdv;
        private System.Windows.Forms.TextBox textUrunBirimi;
        private System.Windows.Forms.TextBox textUrunFiyat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}