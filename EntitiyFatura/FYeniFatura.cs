using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFatura
{
    public partial class FYeniFatura : Form
    {
        public FYeniFatura()
        {
            InitializeComponent();
        }
        FaturaContext ft = new FaturaContext();
        int secilenId;
        List<secilenUrun> urunListesi = new List<secilenUrun>();
        private void FYeniFatura_Load(object sender, EventArgs e)
        {
            MusterSehirDoldur();
            UrunDoldur();
        }

        private void MusterSehirDoldur()
        {
           var list = ft.iller.ToList();
            cmbSehir.DisplayMember = "IlAdi";
            cmbSehir.ValueMember = "Id";
            cmbSehir.DataSource = list;
        }

        private void UrunDoldur()
        {
            var list = ft.Urun.OrderBy(I => I.UrunAdi).Select(I=>new { I.Urunid,I.UrunAdi}).ToList();
            comUrunAdi.DisplayMember = "UrunAdi";
            comUrunAdi.ValueMember = "Urunid";
            comUrunAdi.DataSource = list;
        }
        private void listele()
        {

            dataGridView1.DataSource = urunListesi.Select(x => 
                                      new
                                      {
                                          x.UrunId,
                                          x.UrunAdi,
                                          x.ToplamTutar,
                                          x.UrunFiyat,
                                          x.kdv,
                                          x.miktar,

                                          GenelToplam=x.ToplamTutar+(x.ToplamTutar*x.kdv)/100

                                      });
            dataGridView1.Columns[0].Visible = false;
            faturaToplam();
        }
        private void IlceDoldur()
        {
            var listele = ft.ilceler.Where(x => x.Ilid == (int) cmbSehir.SelectedValue)
                .Select(x=>new {x.Ilceid,x.IlceAdi }).ToList();
            //var list = (from ilceler in ft.ilceler
            //    where ilceler.Ilid == (int) cmbSehir.SelectedValue
            //    select new {ilceler.Ilceid, ilceler.IlceAdi}).ToList();
            comilce.DisplayMember = "IlceAdi";
            comilce.ValueMember = "Ilceid";
            comilce.DataSource = listele;
        }

        private void faturaToplam()
        {
            decimal toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToDecimal(dataGridView1[6, i].Value);
            }

            lblToplamFatura.Text = toplam.ToString("0:0.00") + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var urun = urunListesi.Where(x => x.UrunId == secilenId).FirstOrDefault();
            urunListesi.Remove(urun);
            listele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DbContextTransaction transaction = ft.Database.BeginTransaction();
            try
            {
                FaturaMasterKaydet();
                FaturaDetayKaydet();
                transaction.Commit();
            }
            catch (Exception exception)
            {
              transaction.Rollback();
              MessageBox.Show("Beklenmeyen bir hata oluştu");
            }
        }

        private void FaturaDetayKaydet()
        {
            foreach (secilenUrun item in urunListesi)
            {
                FaturaDetay fd=new FaturaDetay();
                fd.FaturaId = Convert.ToInt32(lblFaturaNo.Text);
                fd.UrunID = item.UrunId;
                fd.Miktar = item.miktar;
                fd.KDV = item.kdv;
                fd.TopkamFiyat = item.miktar * item.UrunFiyat;
                fd.KDVliFiyat = fd.TopkamFiyat * item.kdv / 100;
                ft.FaturaDetay.Add(fd);
                ft.SaveChanges();
            }
        }

        private void FaturaMasterKaydet()
        {
            FaturaMaster faturaMaster=new FaturaMaster();
            faturaMaster.IrsaliyeNo = Convert.ToInt32(textBox1.Text);
            faturaMaster.FaturaTarihi = dateTimePicker1.Value;
            faturaMaster.MusteriID = (int) comMusteri.SelectedValue;
            ft.FaturaMaster.Add(faturaMaster);
            ft.SaveChanges();
            lblFaturaNo.Text = faturaMaster.FaturaID.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            urunListesi.Clear();
        }

        private void comUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {  var u= ft.Urun.Find((int)comUrunAdi.SelectedValue);
            if (u != null)
            {
                textUrunFiyat.Text = u.BirimFiyat.ToString();
                textUrunBirimi.Text = u.birim.BirimAdi.ToString();
            }

            textKdv.Text = "8";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var urun = urunListesi.Where(x => x.UrunId == secilenId).FirstOrDefault();
            comUrunAdi.SelectedValue = secilenId;
            numericUpDown1.Value = urun.miktar;
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceDoldur();
        }

        private void comilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusterDoldur();
            IlceDoldur();
        }

        private void MusterDoldur()
        {
            var mlist = (from m in ft.Musteri
                where m.IlceId == (int) comilce.SelectedValue
                orderby m.MusteriUnvani
                select new
                {
                    m.IlceId,
                    m.MusteriId,
                    m.MusteriUnvani
                }).ToList();
            if (mlist.Count!=0)
            {
                comMusteri.DisplayMember = "MusterUnvani";
                comMusteri.ValueMember = "MusteriId";
                comMusteri.DataSource = mlist;
            }
            else
            {
                comMusteri.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
