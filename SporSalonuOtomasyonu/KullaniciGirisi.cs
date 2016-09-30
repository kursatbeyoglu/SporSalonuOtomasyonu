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
    public partial class KullaniciGirisi : Form
    {
        
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Islemler IslemlerGit = new Islemler();
            //işlemler formuna gidiliyor.
            IslemlerGit.Show();
            //kullanıcıgiriş formu küçülüyor.
            this.Hide();
            
            
        }
    }
}
