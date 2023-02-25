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
    public partial class Form5giris : Form
    {
        public Form5giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityUrunEntities db = new EntityUrunEntities();
            var sorgu = from x in db.TblAdmin where x.kullanıcı == textBox1.Text && x.sifre == textBox2.Text select x; //bu kodu parantez dışındada kullanabilirsin bu şekilde.
            if (sorgu.Any()) //any fonksiyonu sorgu içinde veri var mı yok mu diye kontrol eder
            { 
                Form2main frm = new Form2main();
                frm.Show();
                this.Hide();
                MessageBox.Show("Hoşgeldin " + sorgu.First().kullanıcı);
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }


        }
    }
}
