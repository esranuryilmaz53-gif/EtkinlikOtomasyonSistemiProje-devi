using System;
using System.Windows.Forms;

namespace EtkinlikOtomasyonSistemi
{
    public partial class AdminForm : Form
    {
        UserManager manager;

        public AdminForm(UserManager userManager, string adminName)
        {
            InitializeComponent();
            manager = userManager;
            LoadStudents();
            dgvOgrenciler.DoubleClick += DgvOgrenciler_DoubleClick;
        }

        private void LoadStudents() { dgvOgrenciler.DataSource = null; dgvOgrenciler.DataSource = manager.GetUserListForAdmin(); }

        private void DgvOgrenciler_DoubleClick(object sender, EventArgs e)
        {
            if (dgvOgrenciler.CurrentRow != null)
            {
                string ogrenciAdi = dgvOgrenciler.CurrentRow.Cells["KullanıcıAdı"].Value.ToString();
                if (dgvOgrenciler.CurrentRow.Cells["Görevi"].Value.ToString().Contains("Başkanı")) return;

                string kulupAdi = PromptForClubName(ogrenciAdi);
                if (!string.IsNullOrWhiteSpace(kulupAdi) && manager.PromoteToPresident(ogrenciAdi, kulupAdi))
                {
                    MessageBox.Show($"{ogrenciAdi}, {kulupAdi} başkanı yapıldı!");
                    LoadStudents();
                }
            }
        }

        private string PromptForClubName(string ogrenciAdi)
        {
            Form prompt = new Form() { Width = 350, Height = 150, Text = "Başkan Yap", StartPosition = FormStartPosition.CenterScreen };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 290 };
            Button confirmation = new Button() { Text = "Onayla", Left = 210, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(new Label() { Left = 20, Top = 20, Text = $"{ogrenciAdi} hangi kulübün başkanı?" });
            prompt.Controls.Add(textBox); prompt.Controls.Add(confirmation); prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}