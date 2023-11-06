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
    public partial class Şikayetler : Form
    {
        public Şikayetler()
        {
            InitializeComponent();
        }
        VergiSistemiEntities1 con = new VergiSistemiEntities1();
        private void Şikayetler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Filtreleme1().ToList();
        }
    }
}
