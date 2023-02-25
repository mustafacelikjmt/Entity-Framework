using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    public partial class Form2main : Form
    {
        public Form2main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1kategori frm1 = new Form1kategori();
            frm1.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3urun frm3 = new Form3urun();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4istatistik frm4 = new Form4istatistik();
            frm4.Show();
        }
    }
}
