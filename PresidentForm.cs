using System;
using System.Linq;
using System.Windows.Forms;

namespace EtkinlikOtomasyonSistemi
{
    public partial class PresidentForm : Form
    {
        EventManager manager;
        string clubName;

        public PresidentForm(EventManager eventManager, string cName)
        {
            InitializeComponent();
            manager = eventManager;
            clubName = cName;
            this.Text = "Kulüp Başkanı: " + clubName;

            LoadClubEvents();
            btnCreate.Click += BtnCreate_Click;
        }

        private void LoadClubEvents()
        {
            dgvKulupEtkinlikleri.DataSource = null;
            dgvKulupEtkinlikleri.DataSource = manager.Events.Where(e => e.Organizer == clubName).ToList();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string eName = txtEventName.Text.Trim();
            string eTime = txtEventTime.Text.Trim();
            string eLoc = txtEventLocation.Text.Trim();

            if (string.IsNullOrWhiteSpace(eName) || string.IsNullOrWhiteSpace(eTime) || string.IsNullOrWhiteSpace(eLoc))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            manager.AddEvent(eName, eTime, eLoc, clubName);
            MessageBox.Show("Etkinlik başarıyla oluşturuldu!");

            txtEventName.Clear(); txtEventTime.Clear(); txtEventLocation.Clear();
            LoadClubEvents();
        }
    }
}