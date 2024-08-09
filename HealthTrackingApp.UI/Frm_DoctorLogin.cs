using HealthTrackingApp.Business.Services;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.DataAccess.Repositories;

namespace HealthTrackingApp.UI;

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
        txtPassword.PasswordChar = '*';
    }

    private void btnIntroduction_Click(object sender, EventArgs e)
    {
        string incomingFullName = txtDoctorFullName.Text.Trim().ToLower();
        string incomingPassword = txtPassword.Text;


        var doctor = _doctorService.GetAll()
               .FirstOrDefault(d => d.FullName.Trim().ToLower() == incomingFullName);

        if (_doctorFullName == doctor.FullName && incomingPassword.Equals("admin"))
        {

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
