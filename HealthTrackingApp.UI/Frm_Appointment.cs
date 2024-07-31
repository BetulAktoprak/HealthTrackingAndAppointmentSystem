using HealthTrackingApp.Business.Services;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.DataAccess.Repositories;
using System.Diagnostics;

namespace HealthTrackingApp.UI
{
    public partial class Frm_Appointment : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly DoctorService _doctorService;
        public Frm_Appointment(string ssn, string fullName)
        {
            InitializeComponent();
            _context = new();
            DoctorRepository _doctorRepository = new DoctorRepository(_context);
            _doctorService = new DoctorService(_doctorRepository);

            lblPatientSsn.Text = ssn;
            lblPatientFullName.Text = fullName;
        }

        private void Frm_Appointment_Load(object sender, EventArgs e)
        {
            GetAllDoctorSpeciality();

            foreach (Control item in this.Controls)
            {
                if (item is Button button && button.Tag != null && button.Tag.ToString() == "btnAppointmentSave")
                {
                    button.Click += new EventHandler(btnAppointmentSave_Click);
                }
            }
        }

        private void btnAppointmentSave_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.BackColor == Color.Red)
            {
                MessageBox.Show("Bu saat için randevu alýnmýþ.");
                return;
            }

            DateTime selectedDate = dtpAppointmentDate.Value;
            string selectedTime = clickedButton.Text;


        }

        private void GetAllDoctorSpeciality()
        {

            var specialties = _doctorService.GetAllUniqueSpecialties().OrderBy(s => s).ToList();


            cmbSpecialty.DataSource = null;
            cmbSpecialty.DataSource = specialties;
            cmbSpecialty.Refresh();
        }

        private void cmbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpecialty.SelectedItem != null)
            {
                string selectedSpecialty = cmbSpecialty.SelectedItem.ToString();
                var doctors = _doctorService.GetDoctorsBySpecialty(selectedSpecialty).OrderBy(d => d.FullName).ToList();

                cmbDoctorFullName.DataSource = null;
                cmbDoctorFullName.DataSource = doctors;
                cmbDoctorFullName.DisplayMember = "FullName";
                cmbDoctorFullName.ValueMember = "Id";
                cmbDoctorFullName.Refresh();
            }
        }
    }
}
