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
    public partial class UruEkrani : Form
    {
        public UruEkrani()
        {
            InitializeComponent();
        }
        FaturaContext ft = new FaturaContext();
        int secilenId;

        private void UruEkrani_Load(object sender, EventArgs e)
        {
            BirimListele();
            Listele();
        }
        private void BirimListele()
        {
            var blist = from b in ft.Birimler
                        orderby b.BirimAdi
                        select new
                        {
                            b.Birimid,
                            b.BirimAdi
                        };
            cmbBirimAdi.DisplayMember = "BirimAdi";
            cmbBirimAdi.ValueMember = "Birimid";
            cmbBirimAdi.DataSource = blist.ToList();


        }
        private void Listele()
        {
            var list = from u in ft.Urun
                       orderby u.UrunAdi
                       select new
                       {
                           u.Urunid,
                           u.UrunAdi,
                           u.UrunKodu,
                           u.birim.BirimAdi,
                           u.BirimFiyat
                       };
            dataGridView1.DataSource = list.ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunAdi = textUrunadi.Text;
            u.UrunKodu = textUrunKodu.Text;
            u.BirimFiyat = Convert.ToDecimal(BirimFiyat.Text);
            u.BirimID = (int)cmbBirimAdi.SelectedValue;
            ft.Urun.Add(u);
            ft.SaveChanges();
            Listele();
        }
    }
}
