using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Entity_Framework
{
    public partial class Form1kategori : Form
    {
        public Form1kategori()
        {
            InitializeComponent();
        }
        EntityUrunEntities db = new EntityUrunEntities();
        void list()
        {
            /*var kategoriler = db.TblKategori.ToList();
            dataGridView1.DataSource = kategoriler;*/
            //yukarıya gerek yok
            dataGridView1.DataSource = db.TblKategori.ToList();
        }
        private void buttonlist_Click(object sender, EventArgs e)
        {
            list();
            label4.Text = "";
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            TblKategori yeni = new TblKategori();
            yeni.Ad = textBoxad.Text;
            db.TblKategori.Add(yeni);
            db.SaveChanges();
            label4.Text = "Eklendi";
            list();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxID.Text != "")
            {
                var sil = db.TblKategori.Find(Convert.ToInt32(maskedTextBoxID.Text));
                db.TblKategori.Remove(sil);
                db.SaveChanges();
                label4.Text = "Silindi";
                list();
            }
            
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            var guncelle = db.TblKategori.Find(Convert.ToInt32(maskedTextBoxID.Text));
            guncelle.Ad = textBoxad.Text;
            db.SaveChanges();
            label4.Text = "Güncellendi";
            list();
        }
    }
}
