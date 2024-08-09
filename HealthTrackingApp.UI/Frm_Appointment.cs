using HealthTrackingApp.Business.Services;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.UI;

public partial class Frm_Appointment : Form
{
    private readonly ApplicationDbContext _context;
    private readonly DoctorService _doctorService;
    private readonly AppointmentService _appointmentService;
    private readonly PatientService _patientService;
    private TimeSpan? _selectedTimeSlot = null;
    public Frm_Appointment(string ssn, string fullName)
    {
        InitializeComponent();
        _context = new();
        DoctorRepository _doctorRepository = new DoctorRepository(_context);
        _doctorService = new DoctorService(_doctorRepository);
        AppointmentRepository _appointmentRepository = new AppointmentRepository(_context);
        _appointmentService = new AppointmentService(_appointmentRepository);
        PatientRepository _patientRepository = new PatientRepository(_context);
        _patientService = new PatientService(_patientRepository);

        lblPatientSsn.Text = ssn;
        lblPatientFullName.Text = fullName;
    }

    private void Frm_Appointment_Load(object sender, EventArgs e)
    {
        GetAllDoctorSpeciality();
        PatientAppointmentList(lblPatientSsn.Text);
        UpdateAppointmentStatus();

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

        if (clickedButton != null && clickedButton.Tag != null && clickedButton.Tag.ToString() == "TimeSlot")
        {

            if (!TimeSpan.TryParseExact(clickedButton.Text, @"hh\:mm", null, out TimeSpan selectedTime))
            {
                MessageBox.Show("Geçersiz saat formatý.");
                return;
            }

            _selectedTimeSlot = selectedTime;

            if (clickedButton.BackColor == Color.Red)
            {
                MessageBox.Show("Bu saat için randevu dolu.");
                return;
            }

        }
    }

    private void btnAppointmentSave_Click(object sender, EventArgs e)
    {


        if (_selectedTimeSlot == null)
        {
            MessageBox.Show("Lütfen bir zaman dilimi seçin.");
            return;
        }

        DateTime selectedDate = dtpAppointmentDate.Value;
        string patientSsn = lblPatientSsn.Text;

        //var patient = _context.Patients.FirstOrDefault(p => p.SSN == patientSsn);
        var patient = _patientService.GetAll().FirstOrDefault(p => p.SSN == patientSsn);
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


        DateTime selectedDateTime = selectedDate.Date + _selectedTimeSlot.Value;
        if (selectedDateTime <= DateTime.Now)
        {
            MessageBox.Show("Geçmiþ tarih ve saat için randevu alýnamaz");
            return;
        }

        var existingAppointment = _appointmentService.GetAll().FirstOrDefault(a => a.DoctorId == doctorId && a.AppointmentDate.Value.Date == selectedDate.Date && a.AppointmentTime == _selectedTimeSlot);
        if (existingAppointment != null)
        {
            MessageBox.Show("Lütfen baþka bir randevu saati seçin.");
            return;
        }

        AppointmentSave(selectedDate, _selectedTimeSlot.Value, patientId, doctorId, patientSsn);


        foreach (Control item in grpAppointmentSystem.Controls)
        {
            if (item is Button button && button.Tag != null && button.Tag.ToString() == "TimeSlot" && button.Text == _selectedTimeSlot.Value.ToString(@"hh\:mm"))
            {
                button.BackColor = Color.Red;
            }
        }

        _selectedTimeSlot = null;

        PatientAppointmentList(patientSsn);

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
                    }
                    else
                    {
                        button.BackColor = SystemColors.Control;
                    }
                }
            }
        }
    }

    private List<string> GetReservedTimesForDate(DateTime selectedDate, Guid doctorId)
    {
        var now = DateTime.Now;
        var appointments = _appointmentService.GetAll()
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

    private void PatientAppointmentList(string patientSsn)
    {
        var appointmnetsQuery = from app in _context.Appointments
                                join d in _context.Doctors on app.DoctorId equals d.Id
                                join p in _context.Patients on app.PatientId equals p.Id
                                where p.SSN == patientSsn
                                orderby app.AppointmentDate.Value.Date
                                select new
                                {
                                    Id = app.Id,
                                    UzmanlikAlani = d.Specialty,
                                    DoktorAdiSoyadi = d.FullName,
                                    RandevuTarihi = app.AppointmentDate.Value.ToShortDateString(),
                                    RandevuSaati = app.AppointmentTime.HasValue
                                    ? string.Format("{0:D2}:{1:D2}", app.AppointmentTime.Value.Hours, app.AppointmentTime.Value.Minutes)
                                    : "",
                                    RandevuDurumu = app.Status ? "Gelecek Randevu" : "Geçmiþ Randevu"
                                };

        var appointments = appointmnetsQuery.ToList();

        dgvAppointmentList.DataSource = appointments;

        if (dgvAppointmentList.Columns["Id"] != null)
        {
            dgvAppointmentList.Columns["Id"].Visible = false;
        }
    }

    private void UpdateAppointmentStatus()
    {
        var now = DateTime.Now;
        var appointments = _appointmentService.GetAll()
            .Where(a => a.AppointmentDate.HasValue && a.AppointmentTime.HasValue)
            .ToList();

        foreach (var item in appointments)
        {
            var appointmentDateTime = item.AppointmentDate.Value.Date + item.AppointmentTime.Value;

            if (appointmentDateTime <= now)
            {
                item.Status = false;
                _appointmentService.Update(item);
            }
        }
    }

    private void btnAppintmentUpdate_Click(object sender, EventArgs e)
    {
        if (dgvAppointmentList.SelectedRows.Count == 0)
        {
            MessageBox.Show("Güncellenecek bir randevu seçin.");
            return;
        }

        var selectedRow = dgvAppointmentList.SelectedRows[0];
        Guid appointmentId = (Guid)selectedRow.Cells["Id"].Value;

        var appointment = _appointmentService.GetByID(appointmentId);
        if (appointment == null)
        {
            MessageBox.Show("Randevu bulunamadý.");
            return;
        }

        DateTime appointmentDateTime = appointment.AppointmentDate.Value.Date + appointment.AppointmentTime.Value;
        if (appointmentDateTime <= DateTime.Now || !appointment.Status)
        {
            MessageBox.Show("Sadece gelecekteki randevular güncellenebilir.");
            return;
        }

        if (cmbSpecialty.SelectedItem == null || !(cmbDoctorFullName.SelectedItem is Doctor selectedDoctor))
        {
            MessageBox.Show("Lütfen bir poliklinik ve doktor seçiniz.");
            return;
        }

        if (_selectedTimeSlot == null)
        {
            MessageBox.Show("Lütfen bir zaman dilimi seçin.");
            return;
        }

        appointment.AppointmentDate = dtpAppointmentDate.Value.Date;
        appointment.AppointmentTime = _selectedTimeSlot;
        appointment.DoctorId = selectedDoctor.Id;

        try
        {
            _appointmentService.Update(appointment);
            MessageBox.Show("Randevu baþarýyla güncellendi.");
            PatientAppointmentList(lblPatientSsn.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Güncelleme sýrasýnda bir hata oluþtu: " + ex.Message);
        }

        _selectedTimeSlot = null;
    }

    private void btnAppointmentDelete_Click(object sender, EventArgs e)
    {
        if (dgvAppointmentList.SelectedRows.Count == 0)
        {
            MessageBox.Show("Silmek için bir randevu seçiniz.");
            return;
        }

        var selectedRow = dgvAppointmentList.SelectedRows[0];
        Guid appointmentId = (Guid)selectedRow.Cells["Id"].Value;

        var appointment = _appointmentService.GetByID(appointmentId);
        if (appointment == null)
        {
            MessageBox.Show("Randevu bulunamadý.");
            return;
        }

        DateTime appointmentDateTime = appointment.AppointmentDate.Value.Date + appointment.AppointmentTime.Value;
        if (appointmentDateTime <= DateTime.Now || !appointment.Status)
        {
            MessageBox.Show("Sadece gelecekteki randevular silinebilir.");
            return;
        }

        try
        {
            _appointmentService.Delete(appointment.Id);
            MessageBox.Show("Randevu baþarýyla silindi.");
            PatientAppointmentList(lblPatientSsn.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Randevu silinirken hata oluþtu: " + ex.Message);
        }
    }

    private void btnDoctorAppointmentCalendar_Click(object sender, EventArgs e)
    {
        if (cmbDoctorFullName.SelectedItem == null || !(cmbDoctorFullName.SelectedItem is Doctor selectedDoctor))
        {
            MessageBox.Show("Lütfen bir doktor seçiniz.");
            return;
        }

        Guid doctorId = selectedDoctor.Id;
        DateTime selectedDate = DateTime.Now.Date;

        var appointmentsQuery = from app in _context.Appointments
                                join p in _context.Patients on app.PatientId equals p.Id
                                where app.DoctorId == doctorId && app.AppointmentDate.Value.Date == selectedDate
                                orderby app.AppointmentTime
                                select new
                                {
                                    HastaTC = p.SSN,
                                    HastaAdSoyad = p.FullName,
                                    RandevuSaati = app.AppointmentTime.HasValue
                                        ? string.Format("{0:D2}:{1:D2}", app.AppointmentTime.Value.Hours, app.AppointmentTime.Value.Minutes)
                                        : ""
                                };

        var appointments = appointmentsQuery.ToList();
        dgvDoctorAppointmentList.DataSource = appointments;
    }

    private void btnPatientRegistrationPanel_Click(object sender, EventArgs e)
    {
        Frm_PatientRegistration frm_PatientRegistration = new Frm_PatientRegistration();
        frm_PatientRegistration.Show();

        this.Hide();
    }

    private void btnPatientTreatmentInformation_Click(object sender, EventArgs e)
    {
        if (dgvAppointmentList.SelectedRows.Count > 0)
        {
            var selectedRow = dgvAppointmentList.SelectedRows[0];
            if (selectedRow.Cells["RandevuTarihi"].Value != null)
            {
                if (DateTime.TryParse(selectedRow.Cells["RandevuTarihi"].Value.ToString(), out DateTime appointmentDate))
                {
                    var appointmentStatus = selectedRow.Cells["RandevuDurumu"].Value?.ToString();

                    if (appointmentDate.Date == DateTime.Now.Date && appointmentStatus == "Geçmiþ Randevu")
                    {
                        string Ssn = lblPatientSsn.Text;
                        string patientFullName = lblPatientFullName.Text;
                        string doctorFullName = selectedRow.Cells["DoktorAdiSoyadi"].Value.ToString();

                        Frm_DoctorLogin frm_DoctorLogin = new Frm_DoctorLogin(Ssn, patientFullName, doctorFullName);
                        frm_DoctorLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bugüne ait ve 'Geçmiþ Randevu' olan bir randevu seçin.");
                    }
                }
                else
                {
                    MessageBox.Show("Randevu tarihi geçersiz.");
                }
            }
            else
            {
                MessageBox.Show("Randevu tarihi bulunamadý.");
            }
        }
        else
        {
            MessageBox.Show("Lütfen bir randevu seçin.");
        }

    }

    private void Frm_Appointment_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}
