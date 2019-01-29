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
    public partial class FormIl : Form
    {
        public FormIl()
        {
            InitializeComponent();
        }
        FaturaContext ft = new FaturaContext();
        int secilenId;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = new Il();
                il.IlAdi = textBox1.Text;
                ft.iller.Add(il);
                ft.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {

                string str = ex.Message;
            }

           
        }
        public void Listele()
        {
            var list = ft.iller.Select(I => new
            {
                I.Id,
                I.IlAdi
                
            }).ToList();
            dataGridView1.DataSource = list;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = ft.iller.Find(secilenId);
                il.IlAdi = textBox1.Text;
                ft.SaveChanges();
                Listele();

            }
            catch (Exception)
            {

                MessageBox.Show("Il seçmeniz gerekmektedir...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = ft.iller.Find(secilenId);
                ft.iller.Remove(il);
                ft.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Il seçmeniz gerekmektedir...");
            }
            

        }

        private void FormIl_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId =Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Il i = ft.iller.Find(secilenId);
            textBox1.Text = i.IlAdi;

        }
    }
}
