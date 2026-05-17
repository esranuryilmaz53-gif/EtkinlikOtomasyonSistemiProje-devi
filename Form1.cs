using System;
using System.Windows.Forms;

namespace EtkinlikOtomasyonSistemi
{
    public partial class Form1 : Form
    {
        EventManager eventManager = new EventManager();
        UserManager userManager = new UserManager();

        public Form1()
        {
            InitializeComponent();
            btnGirisYap.Click += BtnGirisYap_Click;
            btnKaydol.Click += BtnKaydol_Click;
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            User loggedInUser = userManager.Login(txtKullaniciAdi.Text.Trim(), txtSifre.Text.Trim());
            if (loggedInUser != null)
            {
                loggedInUser.GetDashboardForm(eventManager, userManager).Show();
                txtKullaniciAdi.Clear(); txtSifre.Clear();
            }
            else MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
        }

        private void BtnKaydol_Click(object sender, EventArgs e)
        {
            string kAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kAdi) || string.IsNullOrEmpty(sifre)) return;

            if (userManager.Register(kAdi, sifre)) MessageBox.Show("Başarıyla kayıt oldunuz! Giriş yapabilirsiniz.");
            else MessageBox.Show("Bu kullanıcı adı zaten mevcut.");
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}