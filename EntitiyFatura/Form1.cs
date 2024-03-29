﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ılEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIl form = new FormIl();
            form.Show();

        }

        private void ılceEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ilceler ilceler = new Ilceler();
            ilceler.Show();
        
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UruEkrani u = new UruEkrani();
            u.Show();
       
        }

        private void birimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBirim b = new FormBirim();
            b.Show();
          
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmusteri m = new Fmusteri();
            m.Show();
           
        }

        private void yeniFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FYeniFatura yf=new FYeniFatura();
            yf.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void faturaSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaSorgulama fs=new FaturaSorgulama();
            fs.Show();
           
        }
    }
}
