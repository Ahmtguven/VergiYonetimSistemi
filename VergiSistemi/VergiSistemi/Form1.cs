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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using VergiSistemi;

namespace VergiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VergiSistemiEntities1 con = new VergiSistemiEntities1();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool Login(string username,string password)
        {
            var query = from user in con.Vatandas where user.TC == username && user.Sifre == password select user;
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoginBakanlık(string username, string password)
        {
            var query = from user in con.Bakanlıklar where user.bakanlıkName == username && user.Password == password select user;

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login(textBox1.Text, textBox2.Text))
            {
                Vatandass go = new Vatandass();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (LoginBakanlık(textBox3.Text, textBox4.Text))
            {
                BakanlıkSist go = new BakanlıkSist();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }

}