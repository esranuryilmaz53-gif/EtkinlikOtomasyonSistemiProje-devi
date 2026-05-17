using System;
using System.Linq;
using System.Windows.Forms;

namespace EtkinlikOtomasyonSistemi
{
    public partial class StudentForm : Form
    {
        EventManager manager;
        string activeStudentName;

        public StudentForm(EventManager eventManager, string studentName)
        {
            InitializeComponent();
            manager = eventManager;
            activeStudentName = studentName;
            this.Text = "Öğrenci Paneli: " + activeStudentName;

            LoadEvents();

            btnKatil.Click += BtnKatil_Click;
            btnAyril.Click += BtnAyril_Click; 
        }

        private void LoadEvents()
        {
            dgvKatildigimEtkinlikler.DataSource = null;
            dgvTumEtkinlikler.DataSource = null;

            
            dgvKatildigimEtkinlikler.DataSource = manager.Events.Where(e => e.JoinedUsers.Contains(activeStudentName)).ToList();

            
            dgvTumEtkinlikler.DataSource = manager.Events.ToList();
        }

        private void BtnKatil_Click(object sender, EventArgs e)
        {
            if (dgvTumEtkinlikler.SelectedRows.Count > 0)
            {
                int eventId = (int)dgvTumEtkinlikler.SelectedRows[0].Cells[0].Value;
                string result = manager.JoinEvent(eventId, activeStudentName);
                MessageBox.Show(result);
                LoadEvents();
            }
        }

        
        private void BtnAyril_Click(object sender, EventArgs e)
        {
            
            if (dgvKatildigimEtkinlikler.SelectedRows.Count > 0)
            {
                int eventId = (int)dgvKatildigimEtkinlikler.SelectedRows[0].Cells[0].Value;

                string result = manager.LeaveEvent(eventId, activeStudentName);
                MessageBox.Show(result);

                LoadEvents(); 
            }
            else
            {
                MessageBox.Show("Lütfen ayrılmak istediğiniz etkinliği 'Katıldığım Etkinlikler' listesinden seçin.");
            }
        }
    }
}