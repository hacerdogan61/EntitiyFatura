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
            cmbSehir.ValueMember = "IlId";
            cmbSehir.DataSource = list;
        }

        private void UrunDoldur()
        {
            var list = ft.Urun.OrderBy(I => I.UrunAdi).Select(I=>new { I.Urunid,I.UrunAdi}).ToList();
            comUrunAdi.DisplayMember = "UrunAdi";
            comUrunAdi.ValueMember = "Urunid";
            comUrunAdi.DataSource = list;
        }
    }
}
