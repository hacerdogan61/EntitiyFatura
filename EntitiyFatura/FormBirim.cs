using System;
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
    public partial class FormBirim : Form
    {
        public FormBirim()
        {
            InitializeComponent();
        }
        FaturaContext ft = new FaturaContext();


        private void FormBirim_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            var list = ft.Birimler.Select(I => new { I.Birimid,I.BirimAdi});
            dataGridView1.DataSource = list.ToList();
        }
    }
}
