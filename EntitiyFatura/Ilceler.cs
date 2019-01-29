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
    public partial class Ilceler : Form
    {
        public Ilceler()
        {
            InitializeComponent();
        }
        FaturaContext ft = new FaturaContext();
        int secilenId;
        private void Ilceler_Load(object sender, EventArgs e)
        {
            cmbListele();
            Listele();
        }
        public void Listele()
        {
            try
            {
                var list = ft.ilceler.Select(x => 
                new { x.Ilid,x.Ilceid, x.IlceAdi ,SehirAdi=x.il.IlAdi})
                    .Where(x=>x.Ilid==(int)comboBox1.SelectedValue)
                    .OrderBy(x=>x.SehirAdi).ToList();

                //var list2 = from i in ft.ilceler
                //            where i.Ilid == (int)comboBox1.SelectedValue
                //            select new { i.Ilid, i.Ilceid, i.il.IlAdi, i.IlceAdi };

                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;

            }
            catch (Exception)
            {

                
            }

        }
        public void cmbListele()
        {
            var list = ft.iller.Select(x => new { x.Id, x.IlAdi }).OrderBy(x => x.IlAdi).ToList();
            comboBox1.DisplayMember = "IlAdi";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = list;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ilce ilce = new Ilce();
            ilce.Ilid = (int)comboBox1.SelectedValue;
            ilce.IlceAdi = textBox1.Text;
            ft.ilceler.Add(ilce);
            ft.SaveChanges();
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce i = ft.ilceler.Find(secilenId);
                i.IlceAdi = textBox1.Text;
                ft.SaveChanges();
                Listele();

            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce i = ft.ilceler.Find(secilenId);
                ft.ilceler.Remove(i);
                ft.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            Ilce i = ft.ilceler.Find(secilenId);
            textBox1.Text = i.IlceAdi;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();

        }
    }
}
