using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuOtomasyonu
{
    public partial class Islemler : Form
    {
        
        
        SporSalonuOtomasyonuEntities db;
        //veritabanı nesnesi oluşturulur.

        void doldur()
        {
            db = new SporSalonuOtomasyonuEntities();
            UyeTablosu.DataSource = db.testTablo.ToList();
            
            //verileri çekmek için kullanılır.
        }

        public Islemler()
        {
            InitializeComponent();
            
        }

        private void Islemler_Load(object sender, EventArgs e)
        {

            doldur();
            //datagridview için veriler doldurulur.

        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            testTablo yenikullanici = new testTablo();
            yenikullanici.KimlikNo = txtEkleKimlikNo.Text.ToString();
            yenikullanici.Ad = txtEkleAd.Text;
            yenikullanici.Soyad = txtEkleSoyad.Text;
            yenikullanici.Telefon = txtEkleTelefon.Text;
            yenikullanici.UyeOlunanTarih = dateTimeEkleUyeTarih.Value;
            if (rbEkle1Aylik.Checked == true)
                yenikullanici.AylikBilgisi = "1 Aylik";
            else if (rbEkle2Aylik.Checked == true)
                yenikullanici.AylikBilgisi = "2 Aylik";
            else if (rbEkle3Aylik.Checked == true)
                yenikullanici.AylikBilgisi = "3 Aylik";
            else if (rbEkle4Aylik.Checked == true)
                yenikullanici.AylikBilgisi = "4 Aylik";

            yenikullanici.UyelikBitisTarihi = dateTimeEkleUyelikBitis.Value;

            db.testTablo.Add(yenikullanici);
            db.SaveChanges();
            doldur();
            


        }

        private void btnEkleTemizle_Click(object sender, EventArgs e)
        {
            txtEkleKimlikNo.Text = "";
            txtEkleAd.Text = "";
            txtEkleSoyad.Text = "";
            dateTimeEkleUyeTarih.Value=DateTime.Now;
            txtEkleAciklama.Text = "";
            txtEkleAd.Text = "";
            txtEkleTelefon.Text = "";
            rbEkle1Aylik.Checked=false;
            rbEkle2Aylik.Checked = false;
            rbEkle3Aylik.Checked = false;
            rbEkle4Aylik.Checked = false;
            dateTimeEkleUyelikBitis.Value = DateTime.Now;
            txtEkleAciklama.Text = "";
                     
        }

        
       
    
    }
}
