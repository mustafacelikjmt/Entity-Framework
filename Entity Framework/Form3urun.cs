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
    public partial class Form3urun : Form
    {
        EntityUrunEntities db = new EntityUrunEntities();

        void list()
        {
            dataGridView1.DataSource = (from x in db.TblUrun
                                        select new
                                        {
                                            x.UrunID,
                                            x.UrunAd,
                                            x.Marka,
                                            x.Stok,
                                            x.Fiyat,
                                            x.TblKategori.Ad, //bu şekilde istediğin tabloya erişebilirsin. x in bağlı bulunduğu tablonun bağlı bulunduğu tabloları görebilirsin.
                                            x.Durum,
                                        }).ToList();

            maskedTextBoxID.Focus();
        }

        public Form3urun()
        {
            InitializeComponent();
        }

        private void buttonlist_Click(object sender, EventArgs e)
        {
            list();
            label9.Text = "";
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            TblUrun ekle = new TblUrun();
            ekle.UrunAd = textBoxad.Text;
            ekle.Marka = textBoxmarka.Text;
            ekle.Stok = short.Parse(textBoxstok.Text);//bu yeni öğrendiğimiz dönüşüm metodu abi
            //bunun yerine convertto larıda kullanabiliriz ama bu daha kolay ve gerektiğinde bu hata verebiliyor
            ekle.Kategori = int.Parse(comboBoxkategori.SelectedValue.ToString());
            ekle.Fiyat = decimal.Parse(textBoxfiyat.Text);
            ekle.Durum = true;
            db.TblUrun.Add(ekle);
            db.SaveChanges();
            label9.Text = "Eklendi";
            list();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxID.Text != "")
            {
                var sil = db.TblUrun.Find(int.Parse(maskedTextBoxID.Text));
                db.TblUrun.Remove(sil);
                db.SaveChanges();
                label9.Text = "Silindi";
                list();
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            var guncelle = db.TblUrun.Find(int.Parse(maskedTextBoxID.Text));
            guncelle.UrunAd = textBoxad.Text;
            guncelle.Marka = textBoxmarka.Text;
            guncelle.Stok = short.Parse(textBoxstok.Text);
            guncelle.Fiyat = decimal.Parse(textBoxfiyat.Text);
            guncelle.Durum = true;
            guncelle.Kategori = int.Parse(comboBoxkategori.Text);
            label9.Text = "Güncellendi";
            list();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            comboBoxkategori.Text = "";
            maskedTextBoxID.Text = "";
            textBoxad.Text = "";
            textBoxmarka.Text = "";
            textBoxstok.Text = "";
            textBoxfiyat.Text = "";
            textBoxdurum.Text = "";
            label9.Text = "Temizlendi";
        }

        private void Form3urun_Load(object sender, EventArgs e)
        {
            var kategoriler = (
                from x in db.TblKategori
                select new
                {
                    x.ID,
                    x.Ad
                }
                ).ToList();
            comboBoxkategori.DataSource = kategoriler;
            comboBoxkategori.ValueMember = "ID";
            comboBoxkategori.DisplayMember = "Ad";
        }
    }
}
