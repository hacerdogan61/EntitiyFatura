using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFatura
{
    public partial class FaturaSorgulama : Form
    {
        public FaturaSorgulama()
        {
            InitializeComponent();
        }
        FaturaContext ft= new FaturaContext();
        private int secilenId;
        private void FaturaSorgulama_Load(object sender, EventArgs e)
        {
            MusteriSehirDoldur();
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = (from f in ft.FaturaMaster
                where f.FaturaID.ToString().Contains(textFaturaNo.Text) 
                orderby f.FaturaTarihi descending
                select new
                {
                    f.FaturaID,
                    f.MusteriID, f.musteri.MusteriUnvani,
                    f.FaturaTarihi,
                    f.OdemeTarihi,
                    f.IrsaliyeNo


                }).ToList();
        }

        private void MusteriSehirDoldur()
        {
            var list = ft.iller.ToList();
            comboSehir.DisplayMember = "IlAdi";
            comboSehir.ValueMember = "Id";
            comboSehir.DataSource = list;
        }

        private void comboSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriIlceDoldur();
        }

        private void MusteriIlceDoldur()
        {
            var list = ft.ilceler.Where(x => x.Ilid == (int) comboSehir.SelectedValue).ToList();
            Comboilce.DisplayMember = "IlceAdi";
            Comboilce.ValueMember = "IlceId";
            Comboilce.DataSource = list;
        }

        private void Comboilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var liste = ft.Musteri.Where(x => x.IlceId == (int) Comboilce.SelectedValue).ToList();
            comboAd.ValueMember = "MusteriId";
            comboAd.DisplayMember = "MusteriUnvani";
            comboAd.DataSource = liste;
        }

        private void comboAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=(from fm in ft.FaturaMaster
                where fm.MusteriID==(int)comboAd.SelectedValue
                      orderby fm.FaturaTarihi
                          select new
                          {
                              fm.FaturaID,
                              fm.MusteriID,
                              fm.musteri.MusteriUnvani,
                              sehir=fm.musteri.ilce.il.IlAdi,
                              ilce=fm.musteri.ilce.IlceAdi,
                              fm.OdemeTarihi,
                              fm.IrsaliyeNo
                          }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            dataGridFaturadetay.DataSource = ft.FaturaDetay.Where(x => x.FaturaId == secilenId).OrderBy(x => x.UrunID)
                .Select(x => new
                {
                    x
                }).ToList();
        }
    }
   
}
