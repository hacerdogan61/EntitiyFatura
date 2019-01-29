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
    public partial class Fmusteri : Form
    {
        public Fmusteri()
        {
            InitializeComponent();
        }
        FaturaContext ft = new FaturaContext();
        private void Fmusteri_Load(object sender, EventArgs e)
        {
            ilDoldur();
            Listele();
        }

        private void Listele()
        {
            var musteri = ft.Musteri.Select(I=>
            new {I.MusteriId,I.MusteriUnvani,I.MusteriAdresi,I.ilce.IlceAdi, SehirAdi=I.ilce.il.IlAdi }).ToList();
            dataGridView1.DataSource = musteri;

        }

        private void ilDoldur()
        {
            var iller = ft.iller.Select(I => new { I.Id, I.IlAdi });
            comboBox1.DisplayMember = "IlAdi";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = iller.ToList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceDoldur();
        }

        private void ilceDoldur()
        {
           var list=ft.ilceler.Where(I=>I.il.Id ==(int)comboBox2.SelectedValue)
                .OrderBy(I=>I.IlceAdi)
                .Select(I=>new { I.Ilid,I.Ilceid,I.IlceAdi});
            comboBox2.DisplayMember = "IlceAdi";
            comboBox2.ValueMember = "Ilceid";
            comboBox2.DataSource = list.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.MusteriUnvani = textBox1.Text;
            m.MusteriAdresi = textBox2.Text;
            m.IlceId = (int)comboBox2.SelectedValue;
            ft.Musteri.Add(m);
            ft.SaveChanges();
            Listele();
        }
    }
    
}
