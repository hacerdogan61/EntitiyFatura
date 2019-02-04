namespace EntitiyFatura
{
    partial class FaturaSorgulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.textFaturaNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.Comboilce = new System.Windows.Forms.ComboBox();
            this.comboAd = new System.Windows.Forms.ComboBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridFaturadetay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaturadetay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura No";
            // 
            // textFaturaNo
            // 
            this.textFaturaNo.Location = new System.Drawing.Point(134, 77);
            this.textFaturaNo.Name = "textFaturaNo";
            this.textFaturaNo.Size = new System.Drawing.Size(135, 22);
            this.textFaturaNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri İlçe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri Şehir";
            // 
            // comboSehir
            // 
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Location = new System.Drawing.Point(431, 35);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(121, 24);
            this.comboSehir.TabIndex = 5;
            this.comboSehir.SelectedIndexChanged += new System.EventHandler(this.comboSehir_SelectedIndexChanged);
            // 
            // Comboilce
            // 
            this.Comboilce.FormattingEnabled = true;
            this.Comboilce.Location = new System.Drawing.Point(431, 70);
            this.Comboilce.Name = "Comboilce";
            this.Comboilce.Size = new System.Drawing.Size(121, 24);
            this.Comboilce.TabIndex = 6;
            this.Comboilce.SelectedIndexChanged += new System.EventHandler(this.Comboilce_SelectedIndexChanged);
            // 
            // comboAd
            // 
            this.comboAd.FormattingEnabled = true;
            this.comboAd.Location = new System.Drawing.Point(431, 114);
            this.comboAd.Name = "comboAd";
            this.comboAd.Size = new System.Drawing.Size(121, 24);
            this.comboAd.TabIndex = 7;
            this.comboAd.SelectedIndexChanged += new System.EventHandler(this.comboAd_SelectedIndexChanged);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(602, 51);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(174, 61);
            this.btnGoster.TabIndex = 8;
            this.btnGoster.Text = "Tüm Siparişleri Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 194);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridFaturadetay
            // 
            this.dataGridFaturadetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFaturadetay.Location = new System.Drawing.Point(-5, 367);
            this.dataGridFaturadetay.Name = "dataGridFaturadetay";
            this.dataGridFaturadetay.RowTemplate.Height = 24;
            this.dataGridFaturadetay.Size = new System.Drawing.Size(806, 194);
            this.dataGridFaturadetay.TabIndex = 10;
            // 
            // FaturaSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 631);
            this.Controls.Add(this.dataGridFaturadetay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.comboAd);
            this.Controls.Add(this.Comboilce);
            this.Controls.Add(this.comboSehir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFaturaNo);
            this.Controls.Add(this.label1);
            this.Name = "FaturaSorgulama";
            this.Text = "FaturaSorgulama";
            this.Load += new System.EventHandler(this.FaturaSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaturadetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFaturaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboSehir;
        private System.Windows.Forms.ComboBox Comboilce;
        private System.Windows.Forms.ComboBox comboAd;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridFaturadetay;
    }
}