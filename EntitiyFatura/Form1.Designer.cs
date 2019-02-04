namespace EntitiyFatura
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ılEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ılceEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.faturaİslemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriEkleToolStripMenuItem,
            this.birimEkleToolStripMenuItem,
            this.urunEkleToolStripMenuItem,
            this.ılEkleToolStripMenuItem,
            this.ılceEkleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem1.Text = "Tanımlamalar";
            // 
            // musteriEkleToolStripMenuItem
            // 
            this.musteriEkleToolStripMenuItem.Name = "musteriEkleToolStripMenuItem";
            this.musteriEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.musteriEkleToolStripMenuItem.Text = "Musteri Ekle";
            this.musteriEkleToolStripMenuItem.Click += new System.EventHandler(this.musteriEkleToolStripMenuItem_Click);
            // 
            // birimEkleToolStripMenuItem
            // 
            this.birimEkleToolStripMenuItem.Name = "birimEkleToolStripMenuItem";
            this.birimEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.birimEkleToolStripMenuItem.Text = "Birim Ekle";
            this.birimEkleToolStripMenuItem.Click += new System.EventHandler(this.birimEkleToolStripMenuItem_Click);
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.urunEkleToolStripMenuItem.Text = "Urun Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // ılEkleToolStripMenuItem
            // 
            this.ılEkleToolStripMenuItem.Name = "ılEkleToolStripMenuItem";
            this.ılEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.ılEkleToolStripMenuItem.Text = "Il Ekle";
            this.ılEkleToolStripMenuItem.Click += new System.EventHandler(this.ılEkleToolStripMenuItem_Click);
            // 
            // ılceEkleToolStripMenuItem
            // 
            this.ılceEkleToolStripMenuItem.Name = "ılceEkleToolStripMenuItem";
            this.ılceEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.ılceEkleToolStripMenuItem.Text = "Ilce Ekle";
            this.ılceEkleToolStripMenuItem.Click += new System.EventHandler(this.ılceEkleToolStripMenuItem_Click);
            // 
            // faturaİslemleriToolStripMenuItem
            // 
            this.faturaİslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFaturaToolStripMenuItem,
            this.faturaSorgulaToolStripMenuItem});
            this.faturaİslemleriToolStripMenuItem.Name = "faturaİslemleriToolStripMenuItem";
            this.faturaİslemleriToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.faturaİslemleriToolStripMenuItem.Text = "Fatura İslemleri";
            // 
            // yeniFaturaToolStripMenuItem
            // 
            this.yeniFaturaToolStripMenuItem.Name = "yeniFaturaToolStripMenuItem";
            this.yeniFaturaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yeniFaturaToolStripMenuItem.Text = "Yeni Fatura";
            this.yeniFaturaToolStripMenuItem.Click += new System.EventHandler(this.yeniFaturaToolStripMenuItem_Click);
            // 
            // faturaSorgulaToolStripMenuItem
            // 
            this.faturaSorgulaToolStripMenuItem.Name = "faturaSorgulaToolStripMenuItem";
            this.faturaSorgulaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.faturaSorgulaToolStripMenuItem.Text = "Fatura Sorgula";
            this.faturaSorgulaToolStripMenuItem.Click += new System.EventHandler(this.faturaSorgulaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 673);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem musteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ılEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ılceEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaSorgulaToolStripMenuItem;
    }
}

