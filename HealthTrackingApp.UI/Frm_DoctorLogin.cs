using HealthTrackingApp.Business.Services;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthTrackingApp.UI
{
    public partial class Frm_DoctorLogin : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly DoctorService _doctorService;
        private string _ssn;
        private string _patientFullName;
        private string _doctorFullName;
        public Frm_DoctorLogin(string ssn, string fullName, string doctorFullName)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            DoctorRepository _doctorRepository = new DoctorRepository(_context);
            _doctorService = new DoctorService(_doctorRepository);

            _ssn = ssn;
            _patientFullName = fullName;
            _doctorFullName = doctorFullName;
        }

        private void Frm_DoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            string incomingFullName = txtDoctorFullName.Text.Trim().ToLower();
            string incomingPassword = txtPassword.Text;


            var doctor = _doctorService.GetAll()
                   .FirstOrDefault(d => d.FullName.Trim().ToLower() == incomingFullName);

            if (doctor != null && incomingPassword.Equals("admin"))
            {
                _doctorFullName = doctor.FullName;

                Frm_PatientTreatmentInformation frm_PatientTreatmentInformation = new Frm_PatientTreatmentInformation(_ssn, _patientFullName, _doctorFullName);
                frm_PatientTreatmentInformation.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Geçersiz isim veya şifre.");
            }
        }
    }
}
