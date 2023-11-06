using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VergiSistemi
{
    public partial class Vatandass : Form
    {
        public Vatandass()
        {
            InitializeComponent();
        }
        VergiSistemiEntities1 con = new VergiSistemiEntities1();

        private void Vatandass_Load(object sender, EventArgs e)
        {
            //*dataGridView1.DataSource = con.KisiVergiList().ToList(); //Sadece giriş yapılan tc nin verilerini getirecek sorguyu yaz

            richTextBox2.Visible = false;
            comboBox1.Visible = false;
            button3.Visible = false;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            comboBox1.Visible = true;
            button3.Visible = true;

            comboBox1.DataSource = con.Bakanlıklar.ToList();
            comboBox1.ValueMember = "BakanlıkName";
            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox dan seçilen değere göre text boxa değer atamaya bak
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sikayet sikayet = new Sikayet();
            sikayet.TC = textBox1.Text;
            sikayet.Metin = richTextBox1.Text;
            sikayet.BakanlıkName = comboBox1.Text;
            sikayet.BakanlıkId = Convert.ToInt32(textBox2.Text);
            sikayet.Tarih = DateTime.Now;  
            con.SikayetAdd(sikayet.BakanlıkId, sikayet.TC, sikayet.Metin, sikayet.BakanlıkName, sikayet.Tarih);
            con.SaveChanges();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
