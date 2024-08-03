using HealthTrackingApp.Business.Services;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace HealthTrackingApp.UI
{
    public partial class Frm_Appointment : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly DoctorService _doctorService;
        private readonly AppointmentService _appointmentService;
        private TimeSpan? _selectedTimeSlot = null;
        public Frm_Appointment(string ssn, string fullName)
        {
            InitializeComponent();
            _context = new();
            DoctorRepository _doctorRepository = new DoctorRepository(_context);
            _doctorService = new DoctorService(_doctorRepository);
            AppointmentRepository _appointmentRepository = new AppointmentRepository(_context);
            _appointmentService = new AppointmentService(_appointmentRepository);

            lblPatientSsn.Text = ssn;
            lblPatientFullName.Text = fullName;
        }

        private void Frm_Appointment_Load(object sender, EventArgs e)
        {
            GetAllDoctorSpeciality();

            foreach (Control item in grpAppointmentSystem.Controls)
            {
                if (item is Button button && button.Tag != null && button.Tag.ToString() == "TimeSlot")
                {
                    button.Click += new EventHandler(btnTimeSlot_Click);
                }
            }

            cmbDoctorFullName.SelectedIndexChanged += new EventHandler(cmbDoctorFullName_SelectedIndexChanged);
        }

        private void btnTimeSlot_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null && clickedButton.Tag.ToString() == "TimeSlot")
            {
                if (clickedButton.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu saat için randevu alýnmýþ.");
                    return;
                }

                if (!TimeSpan.TryParseExact(clickedButton.Text, @"hh\:mm", null, out TimeSpan selectedTime))
                {
                    MessageBox.Show("Geçersiz saat formatý.");
                    return;
                }

                _selectedTimeSlot = selectedTime;
                MessageBox.Show($"Seçili saat: {clickedButton.Text}");
            }
        }



        private void btnAppointmentSave_Click(object sender, EventArgs e)
        {
            if (_selectedTimeSlot == null)
            {
                MessageBox.Show("Bu saat için randevu alýnmýþ.");
                return;
            }

            DateTime selectedDate = dtpAppointmentDate.Value;
            string patientSsn = lblPatientSsn.Text;

            var patient = _context.Patients.FirstOrDefault(p => p.SSN == patientSsn);
            if (patient == null)
            {
                MessageBox.Show("Hasta bulunamadý");
                return;
            }

            Guid patientId = patient.Id;

            if (cmbSpecialty.SelectedItem == null || !(cmbDoctorFullName.SelectedItem is Doctor selectedDoctor))
            {
                MessageBox.Show("Lütfen bir doktor ve uzmanlýk seçin.");
                return;
            }

            Guid doctorId = selectedDoctor.Id;

            AppointmentSave(selectedDate, _selectedTimeSlot.Value, patientId, doctorId, patientSsn);

            // Seçilen zaman dilimini kýrmýzýya boyayýn ve temizleyin
            foreach (Control item in grpAppointmentSystem.Controls)
            {
                if (item is Button button && button.Text == _selectedTimeSlot.Value.ToString(@"hh\:mm"))
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                }
            }

            _selectedTimeSlot = null;

            //Button clickedButton = sender as Button;

            //if (clickedButton != null && clickedButton.Tag.ToString() == "TimeSlot")
            //{
            //    if (clickedButton.BackColor == Color.Red)
            //    {
            //        MessageBox.Show("Bu saat için randevu alýnmýþ.");
            //        return;
            //    }

            //DateTime selectedDate = dtpAppointmentDate.Value;
            //TimeSpan selectedTime;
            //MessageBox.Show(clickedButton.Text);
            //if (!TimeSpan.TryParseExact(clickedButton.Text, @"hh\:mm", null, out selectedTime))
            //{
            //    MessageBox.Show("Geçersiz saat formatý.");
            //    return;
            //}

            //string patientSsn = lblPatientSsn.Text;

            //var patient = _context.Patients.FirstOrDefault(p => p.SSN == patientSsn);
            //if (patient == null)
            //{
            //    MessageBox.Show("Hasta bulunamadý");
            //    return;
            //}

            //Guid patientId = patient.Id;

            //string selectedSpecialty = cmbSpecialty.SelectedItem.ToString();
            //var selectedDoctor = cmbDoctorFullName.SelectedItem as Doctor;

            //if (selectedDoctor == null)
            //{
            //    MessageBox.Show("Lütfen bir doktor seçin.");
            //    return;
            //}

            //Guid doctorId = selectedDoctor.Id;

            //AppointmentSave(selectedDate, selectedTime, patientId, doctorId, patientSsn);

            //clickedButton.BackColor = Color.Red;
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen geçerli bir saat seçiniz.");
            //}
        }
        private void AppointmentSave(DateTime appointmentDate, TimeSpan appointmentTime, Guid patientId, Guid doctorId, string patientSsn)
        {
            Appointment newAppointment = new Appointment()
            {
                PatientId = patientId,
                DoctorId = doctorId,
                AppointmentDate = appointmentDate,
                AppointmentTime = appointmentTime,
                SSN = patientSsn,
                Status = true
            };

            _appointmentService.Add(newAppointment);

            MessageBox.Show("Randevu baþarýyla kayýt edildi");
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

        private void dtpAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimeSlots();
        }

        private void UpdateTimeSlots()
        {
            DateTime selectedDate = dtpAppointmentDate.Value;

            if (cmbDoctorFullName.SelectedItem is Doctor selectedDoctor)
            {
                List<string> reservedTimes = GetReservedTimesForDate(selectedDate, selectedDoctor.Id);

                foreach (Control item in grpAppointmentSystem.Controls)
                {
                    if (item is Button button && button.Tag != null && button.Tag.ToString() == "TimeSlot")
                    {
                        if (reservedTimes.Contains(button.Text))
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                        else
                        {
                            button.BackColor = SystemColors.Control;
                            button.Enabled = true;
                        }
                    }
                }
            }
        }

        private List<string> GetReservedTimesForDate(DateTime selectedDate, Guid doctorId)
        {
            var now = DateTime.Now;
            var appointments = _context.Appointments
                .Where(a => a.AppointmentDate.Value.Date == selectedDate.Date && a.AppointmentTime.HasValue && a.DoctorId == doctorId)
                .Select(a => new { a.AppointmentTime, a.AppointmentDate })
                .ToList();

            List<string> reservedTimes = new List<string>();

            foreach (var item in appointments)
            {
                var appointmentDateTime = item.AppointmentDate.Value.Date + item.AppointmentTime.Value;
                if (appointmentDateTime > now)
                {
                    reservedTimes.Add(string.Format("{0:D2}:{1:D2}", item.AppointmentTime.Value.Hours, item.AppointmentTime.Value.Minutes));
                }
            }

            return reservedTimes;
        }

        private void cmbDoctorFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTimeSlots();
        }
    }
}
