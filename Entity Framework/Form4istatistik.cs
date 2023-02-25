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
    public partial class Form4istatistik : Form
    {
        public Form4istatistik()
        {
            InitializeComponent();
        }
        EntityUrunEntities db = new EntityUrunEntities();

        private void Form4istatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TblKategori.Count().ToString(); //count sayma
            label3.Text = db.TblUrun.Count().ToString();
            label5.Text = db.TblMusteri.Count(x => x.Durum == true).ToString(); //count parantezinin içine başka şartlarda yazabilirsin mesela parantezin içine && x.MusteriAd == "Ali" gibi bi şart daha ekleyebilirsin.
            label7.Text = db.TblMusteri.Count(x => x.Durum == false).ToString();
            label9.Text = db.TblUrun.Count(x => x.Kategori == 1).ToString();
            label11.Text = db.TblUrun.Sum(x => x.Stok).ToString(); //sum toplama
            label13.Text = (from x in db.TblUrun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();    //ascending a dan z ye descending z den a ya descendingde en yüksek olan en başta olur.
            label15.Text = (from x in db.TblUrun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            label17.Text = (from x in db.TblMusteri select x.Sehir).Distinct().Count().ToString(); //Distinct veriyi tekrarsız olarak getirir
            label19.Text = db.TblSatis.Sum(x => x.Fiyat).ToString() + "TL";
            label21.Text = db.markagetir().FirstOrDefault();
            label23.Text = db.TblUrun.Count(x => x.UrunAd == "Buzdolabı").ToString();
        }
    }
}
