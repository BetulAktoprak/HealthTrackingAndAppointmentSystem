using HealthTrackingApp.Business.Services;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;
using HealthTrackingApp.UI.Tools;
using System.Data;
using System.Globalization;

namespace HealthTrackingApp.UI;

public partial class Frm_PatientTreatmentInformation : Form
{
    private readonly ApplicationDbContext _context;
    private readonly PrescriptionService _prescriptionService;
    private readonly TreatmentPlanService _treatmentPlanService;
    private readonly MedicalTestService _medicalTestService;
    private readonly DoctorService _doctorService;
    private readonly PatientService _patientService;

    private string _doctorFullName;
    private string _ssn;

    private List<object> _treatmentInformationList = new List<object>();

    public Frm_PatientTreatmentInformation(string ssn, string fullName, string doctorFullName)
    {
        InitializeComponent();
        lblPatientSsn.Text = ssn;
        lblPatientFullName.Text = fullName;
        _doctorFullName = doctorFullName;
        _ssn = ssn;

        _context = new ApplicationDbContext();
        PrescriptionRepository _prescriptionRepository = new PrescriptionRepository(_context);
        _prescriptionService = new PrescriptionService(_prescriptionRepository);
        TreatmentPlanRepository _treatmentPlanRepository = new TreatmentPlanRepository(_context);
        _treatmentPlanService = new TreatmentPlanService(_treatmentPlanRepository);
        MedicalTestRepository _medicalTestRepository = new MedicalTestRepository(_context);
        _medicalTestService = new MedicalTestService(_medicalTestRepository);
        DoctorRepository _doctorRepository = new DoctorRepository(_context);
        _doctorService = new DoctorService(_doctorRepository);
        PatientRepository _patientRepository = new PatientRepository(_context);
        _patientService = new PatientService(_patientRepository);

    }

    private void Frm_PatientTreatmentInformation_Load(object sender, EventArgs e)
    {

        PatientTreatmentInformationList();

        PopulateCheckListBox();

        LoadSelectedMedications();

    }

    private void PopulateCheckListBox()
    {
        medicationList.Items.Clear();

        medicationList.Items.Add("A-FERIN SINUS 20 FILM TABLET");
        medicationList.Items.Add("DEVIT-3 200.000 IU/ 10 ML ORAL DAMLA, COZELTI");
        medicationList.Items.Add("DEVIT-3 2.000 IU YUMUSAK KAPSUL (60 KAPSUL)");
        medicationList.Items.Add("DOLOREX 50 MG 20 DRAJE)");
        medicationList.Items.Add("DOLTE %0,5 GOZ DAMLASI 5ML");
        medicationList.Items.Add("DOLVEN 400 MG 20 FİLM TABLET");
        medicationList.Items.Add("DR. GO FINE INSULIN KALEM IGNESI 32G*4mm");
        medicationList.Items.Add("IBURAMIN COLD 100 ML SURUP");
        medicationList.Items.Add("IBURAMIN COLD 24 FILM KAPLI TABLET");
        medicationList.Items.Add("MAJEZIK 100 MG 15 FILM TABLET");
        medicationList.Items.Add("PAROL 500 MG 20 TABLET");
        medicationList.Items.Add("RENNIE 680 MG 48 CIGNEME TABLETI");
    }

    private List<string> GetSelectedMedications()
    {
        List<string> selectedMedications = new List<string>();

        foreach (var item in medicationList.CheckedItems)
        {
            selectedMedications.Add(item.ToString());
        }

        return selectedMedications;

    }
    private void LoadSelectedMedications()
    {
        var prescription = _prescriptionService.GetAll()
            .FirstOrDefault(p => p.PatientId == _patientService.GetAll()
            .FirstOrDefault(p => p.SSN == _ssn)?.Id);

        if (prescription != null)
        {
            var currentItems = medicationList.Items.Cast<string>().ToList();
            medicationList.Items.Clear();

            PopulateCheckListBox();

            foreach (var item in currentItems)
            {
                if (prescription.Medications.Contains(item))
                {
                    int index = medicationList.Items.IndexOf(item);
                    if (index >= 0)
                    {
                        medicationList.SetItemChecked(index, true);
                    }
                }
            }
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var patient = _patientService.GetAll().FirstOrDefault(p => p.SSN == _ssn);

        if (patient == null)
        {
            MessageBox.Show("Geçerli bir hasta bulunamadı.");
            return;
        }

        var doctor = _doctorService.GetAll().FirstOrDefault(d => d.FullName == _doctorFullName);

        if (doctor == null)
        {
            MessageBox.Show("Geçerli bir doktor bulunamadı.");
            return;
        }

        List<string> selectedMedications = GetSelectedMedications();

        Prescription prescription = new Prescription()
        {
            Instructions = rtxtInstructions.Text,
            PrescriptionDate = DateTime.Now.Date,
            DoctorId = doctor.Id,
            PatientId = patient.Id
        };

        prescription.Medications.AddRange(selectedMedications);

        _prescriptionService.Add(prescription);

        TreatmentPlan treatmentPlan = new TreatmentPlan()
        {
            Description = rtxtDescription.Text,
            TreatmentEndDate = string.IsNullOrWhiteSpace(mtxtTreatmentEndDate.Text) ? (DateTime?)null : DateTime.ParseExact(mtxtTreatmentEndDate.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture),
            TreatmentStartDate = DateTime.Now.Date,
            DoctorId = doctor.Id,
            PatientId = patient.Id,
            PrescriptionId = prescription.Id
        };
        _treatmentPlanService.Add(treatmentPlan);

        MedicalTest medicalTest = new MedicalTest()
        {
            TestName = rtxtTestName.Text,
            TestDate = string.IsNullOrWhiteSpace(mtxtTestDate.Text) ? (DateTime?)null : DateTime.Parse(mtxtTestDate.Text),
            Result = rtxtResult.Text,
            Notes = rtxtNotes.Text,
            PatientId = patient.Id,
            PrescriptionId = prescription.Id
        };
        _medicalTestService.Add(medicalTest);


        MessageBox.Show("Hasta bilgileri başarıyla kayıt edildi.");

        FormHelper.ClearForm(this);

        PatientTreatmentInformationList();

    }

    private void PatientTreatmentInformationList()
    {
        var newList = new List<dynamic>();

        var patient = _patientService.GetAll().FirstOrDefault(p => p.SSN == _ssn);

        if (patient == null)
        {
            MessageBox.Show("Geçerli bir hasta bulunamadı.");
            return;
        }

        var prescriptionList = _prescriptionService.GetAll().Where(p => p.PatientId == patient.Id).ToList();
        var treatmentPlanList = _treatmentPlanService.GetAll().Where(tp => tp.PatientId == patient.Id).ToList();
        var medicalTestList = _medicalTestService.GetAll().Where(mt => mt.PatientId == patient.Id).ToList();

        foreach (var prescription in prescriptionList)
        {
            var treatmentPlan = treatmentPlanList.FirstOrDefault(tp => tp.PrescriptionId == prescription.Id);
            var medicalTest = medicalTestList.FirstOrDefault(mt => mt.PrescriptionId == prescription.Id);

            newList.Add(new
            {
                Instructions = prescription.Instructions,
                PrescriptionDate = prescription.PrescriptionDate!.Value.ToString("dd.MM.yyyy"),
                Medications = string.Join(", ", prescription.Medications),
                TreatmentDescription = treatmentPlan?.Description ?? string.Empty,
                TreatmentEndDate = treatmentPlan?.TreatmentEndDate?.ToString("dd.MM.yyyy") ?? string.Empty,
                TestName = medicalTest?.TestName ?? string.Empty,
                TestDate = medicalTest?.TestDate?.ToString("dd.MM.yyyy") ?? string.Empty,
                TestResult = medicalTest?.Result ?? string.Empty,
                TestNotes = medicalTest?.Notes ?? string.Empty
            });
        }

        dgvPatientTreatmentInformation.DataSource = null;
        dgvPatientTreatmentInformation.DataSource = newList.ToList();

        ConfigurationDataGridView();
    }

    private void ConfigurationDataGridView()
    {
        dgvPatientTreatmentInformation.Columns["Instructions"].HeaderText = "Talimatlar";
        dgvPatientTreatmentInformation.Columns["PrescriptionDate"].HeaderText = "Reçete Tarihi";
        dgvPatientTreatmentInformation.Columns["Medications"].HeaderText = "İlaçlar";
        dgvPatientTreatmentInformation.Columns["TreatmentDescription"].HeaderText = "TedaviA çıklaması";
        dgvPatientTreatmentInformation.Columns["TreatmentEndDate"].HeaderText = "Tedavi Bitiş";
        dgvPatientTreatmentInformation.Columns["TestName"].HeaderText = "Test Adı";
        dgvPatientTreatmentInformation.Columns["TestDate"].HeaderText = "Test Tarihi";
        dgvPatientTreatmentInformation.Columns["TestResult"].HeaderText = "Test Sonucu";
        dgvPatientTreatmentInformation.Columns["TestNotes"].HeaderText = "Notlar";

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        var patient = _patientService.GetAll().FirstOrDefault(p => p.SSN == _ssn);

        if (patient == null)
        {
            MessageBox.Show("Geçerli bir hasta bulunamadı.");
            return;
        }

        var doctor = _doctorService.GetAll().FirstOrDefault(d => d.FullName == _doctorFullName);

        if (doctor == null)
        {
            MessageBox.Show("Geçerli bir doktor bulunamadı.");
            return;
        }

        var selectedRow = dgvPatientTreatmentInformation.SelectedRows.Count > 0
            ? dgvPatientTreatmentInformation.SelectedRows[0].DataBoundItem as dynamic
            : null;

        if (selectedRow == null)
        {
            MessageBox.Show("Güncellenecek bir kayıt seçilmedi.");
            return;
        }

        var prescription = _prescriptionService.GetAll().FirstOrDefault(p => p.Instructions == selectedRow.Instructions && p.PrescriptionDate.Value.ToString("dd.MM.yyyy") == selectedRow.PrescriptionDate);

        if (prescription != null)
        {
            prescription.Instructions = rtxtInstructions.Text;
            prescription.PrescriptionDate = DateTime.Now.Date;
            prescription.Medications = GetSelectedMedications();

            _prescriptionService.Update(prescription);
        }

        var treatmentPlan = _treatmentPlanService.GetAll().FirstOrDefault(tp => tp.PrescriptionId == prescription?.Id);
        if (treatmentPlan != null)
        {
            treatmentPlan.Description = rtxtDescription.Text;
            treatmentPlan.TreatmentEndDate = string.IsNullOrWhiteSpace(mtxtTreatmentEndDate.Text) ? (DateTime?)null : DateTime.ParseExact(mtxtTreatmentEndDate.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            _treatmentPlanService.Update(treatmentPlan);
        }

        var medicalTest = _medicalTestService.GetAll().FirstOrDefault(mt => mt.PrescriptionId == prescription?.Id);
        if (medicalTest != null)
        {
            medicalTest.TestName = rtxtTestName.Text;
            medicalTest.TestDate = string.IsNullOrWhiteSpace(mtxtTestDate.Text) ? (DateTime?)null : DateTime.Parse(mtxtTestDate.Text);
            medicalTest.Result = rtxtResult.Text;
            medicalTest.Notes = rtxtNotes.Text;

            _medicalTestService.Update(medicalTest);
        }

        MessageBox.Show("Hasta bilgileri başarıyla güncellendi.");

        FormHelper.ClearForm(this);

        PatientTreatmentInformationList();
    }

    private void dgvPatientTreatmentInformation_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvPatientTreatmentInformation.SelectedRows.Count > 0)
        {
            var selectedRow = dgvPatientTreatmentInformation.SelectedRows[0].DataBoundItem as dynamic;

            if (selectedRow != null)
            {
                rtxtInstructions.Text = selectedRow.Instructions;
                medicationList.Text = selectedRow.Medications;
                rtxtDescription.Text = selectedRow.TreatmentDescription;
                mtxtTreatmentEndDate.Text = selectedRow.TreatmentEndDate;
                rtxtTestName.Text = selectedRow.TestName;
                mtxtTestDate.Text = selectedRow.TestDate;
                rtxtResult.Text = selectedRow.TestResult;
                rtxtNotes.Text = selectedRow.TestNotes;
            }
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string searchText = txtSearch.Text.ToLower();

        if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 2)
        {
            var filteredMedications = medicationList.Items.Cast<string>()
                .Where(medication => medication.ToLower().Contains(searchText))
                .ToList();

            medicationList.Items.Clear();
            foreach (var item in filteredMedications)
            {
                medicationList.Items.Add(item);
            }
        }
        else
        {
            PopulateCheckListBox();
        }
    }
}
