using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VergiSistemi
{
    public partial class BakanlıkSist : Form
    {
        public BakanlıkSist()
        {
            InitializeComponent();
        }
        VergiSistemiEntities1 con = new VergiSistemiEntities1();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Text = column.Cells["vergiName"].Value.ToString();
            textBox2.Text = column.Cells["Tipi"].Value.ToString();
            textBox3.Text = column.Cells["Tutar"].Value.ToString();
            textBox4.Text = column.Cells["Faiz"].Value.ToString();
            textBox5.Text = column.Cells["KisiNo"].Value.ToString();
            textBox5.Text = column.Cells["BakanlıkId"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vergiler vergi = new Vergiler();
            vergi.vergiName = textBox1.Text;
            vergi.Tipi=textBox2.Text;
            vergi.Tutar= Convert.ToDecimal(textBox3.Text);
            vergi.Faiz=Convert.ToInt32(textBox4.Text);
            vergi.KisiNo = Convert.ToInt32(textBox5.Text);
            vergi.BakanlıkId= Convert.ToInt32(textBox6.Text);
            con.VergiAdd(vergi.vergiName, vergi.Tipi, vergi.Tutar, vergi.Faiz,vergi.KisiNo,vergi.BakanlıkId);
            con.SaveChanges();
            dataGridView1.DataSource=con.VergiList().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vergiler vergi = new Vergiler();
            vergi.VergiId = Convert.ToInt32(textBox7.Text);
            vergi.vergiName = textBox1.Text;
            vergi.Tipi = textBox2.Text;
            vergi.Tutar = Convert.ToDecimal(textBox3.Text);
            vergi.Faiz = Convert.ToInt32(textBox4.Text);
            vergi.KisiNo = Convert.ToInt32(textBox5.Text);
            vergi.BakanlıkId = Convert.ToInt32(textBox6.Text);
            con.VergiUpdate(vergi.VergiId,vergi.vergiName,vergi.Tipi,vergi.Tutar,vergi.Faiz,vergi.KisiNo,vergi.BakanlıkId);
            con.SaveChanges();
            dataGridView1.DataSource = con.VergiList().ToList();
        }

        private void BakanlıkSist_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=con.VergiList().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vergiler vergi = new Vergiler();
            vergi.VergiId = Convert.ToInt32(textBox5.Text);
            con.VergiDell(vergi.VergiId);
            con.SaveChanges();
            dataGridView1.DataSource = con.VergiList().ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = con.BakanlıkFiltreleme().ToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = con.KisiVergiListesi().ToList();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = con.Filtreleme1().ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar();
            go.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
