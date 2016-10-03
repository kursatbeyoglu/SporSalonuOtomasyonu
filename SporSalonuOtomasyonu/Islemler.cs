using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

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
            //UyeTablosu datagridviewin adıdır.
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
            yenikullanici.Aciklama = txtEkleAciklama.Text;

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





        //bir numara yazıldığında var olup olmadığının kontrolüde yapılacak!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!




        private void btnSilKayit_Click(object sender, EventArgs e)
        {
            string sil = txtSilKimlikNo.Text;
            var silkisi = db.testTablo.Where(silinicek => silinicek.KimlikNo == sil).FirstOrDefault();
            db.testTablo.Remove(silkisi);
            db.SaveChanges();
            doldur();
        }

        private void txtSilKimlikNo_TextChanged(object sender, EventArgs e)
        {

            //arama algoritmasını yaz mutlaka !!!!!!!!!!!!!!!!!!!!
            

        }

        private void btnGuncelleTemizle_Click(object sender, EventArgs e)
        {
            txtGuncelleKimlik.Text = "";
            txtGuncelleAd.Text="";
            txtGuncelleSoyad.Text="";
            txtGuncelleTelefon.Text = "";
            dateTimeGuncelleUyelikBaslangic.Value = DateTime.Now;
            rbGuncelle1Aylik.Checked = false;
            rbGuncelle2Aylik.Checked = false;
            rbGuncelle3Aylik.Checked = false;
            rbGuncelle6Aylik.Checked = false;
            datetimeGuncelleUyelikSonlanacakTarih.Value = DateTime.Now;
            textBoxGuncelleAciklama.Text = "";


        }

        private void btnGuncelleKayit_Click(object sender, EventArgs e)
        {

        }

        
       
    
    }
}
