using HealthTrackingApp.Business.Services;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace HealthTrackingApp.UI
{
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
                // Önce CheckListBox'ı temizle
                var currentItems = medicationList.Items.Cast<string>().ToList();
                medicationList.Items.Clear();

                // CheckListBox'ı doldur
                PopulateCheckListBox();

                // İlaçları işaretle
                foreach (var item in currentItems)
                {
                    if (prescription.Medications.Contains(item))
                    {
                        int index = medicationList.Items.IndexOf(item);
                        if (index >= 0) // Item bulunursa
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
                PatientId = patient.Id
            };
            _treatmentPlanService.Add(treatmentPlan);

            MedicalTest medicalTest = new MedicalTest()
            {
                TestName = rtxtTestName.Text,
                TestDate = string.IsNullOrWhiteSpace(mtxtTestDate.Text) ? (DateTime?)null : DateTime.Parse(mtxtTestDate.Text),
                Result = rtxtResult.Text,
                Notes = rtxtNotes.Text,
                PatientId = patient.Id
            };
            _medicalTestService.Add(medicalTest);

            MessageBox.Show("Hasta bilgileri başarıyla kayıt edildi.");
            PatientTreatmentInformationList();

        }

        //private void PatientTreatmentInformationList()
        //{
        //    dgvPatientTreatmentInformation.DataSource = null;

        //    var treatmentInformation = _context.Patients
        //        .Include(p => p.Prescriptions)
        //        .Include(p => p.TreatmentPlans)
        //        .Include(p => p.MedicalTests)
        //        .Where(p => p.SSN == _ssn)
        //        .Select(p => new
        //        {
        //            PrescriptionId = p.Prescriptions.Any() ? p.Prescriptions.First().Id : (Guid?)null,
        //            TreatmentPlanId = p.TreatmentPlans.Any() ? p.TreatmentPlans.First().Id : (Guid?)null,
        //            MedicalTestId = p.MedicalTests.Any() ? p.MedicalTests.First().Id : (Guid?)null,
        //            Talimatlar = p.Prescriptions.Any() ? p.Prescriptions.First().Instructions : null,
        //            Açıklama = p.TreatmentPlans.Any() ? p.TreatmentPlans.First().Description : null,
        //            TedaviBitisTarihi = p.TreatmentPlans.Any() ? p.TreatmentPlans.First().TreatmentEndDate : (DateTime?)null,
        //            TestAdı = p.MedicalTests.Any() ? p.MedicalTests.First().TestName : null,
        //            TestTarihi = p.MedicalTests.Any() ? p.MedicalTests.First().TestDate : (DateTime?)null,
        //            Sonuç = p.MedicalTests.Any() ? p.MedicalTests.First().Result : null,
        //            Notlar = p.MedicalTests.Any() ? p.MedicalTests.First().Notes : null
        //        })
        //        .ToList();

        //    dgvPatientTreatmentInformation.DataSource = treatmentInformation;
        //}


        private void PatientTreatmentInformationList()
        {
            var patient = _context.Patients
                .Include(p => p.Prescriptions)
                .Include(p => p.TreatmentPlans)
                .Include(p => p.MedicalTests)
                .FirstOrDefault(p => p.SSN == _ssn);

            if (patient == null)
            {
                MessageBox.Show("Bu SSN ile eşleşen hasta bulunamadı.");
                return;
            }

            var treatmentInformation = new List<object>();


            foreach (var prescription in patient.Prescriptions)
            {
                var treatmentPlan = patient.TreatmentPlans
            .FirstOrDefault(tp => tp.PatientId == patient.Id); // İlgili tedavi planını getirin
                var medicalTest = patient.MedicalTests
                    .FirstOrDefault(mt => mt.PatientId == patient.Id);

                treatmentInformation.Add(new
                {
                    PrescriptionId = prescription.Id != null ? prescription.Id : (Guid?)null,
                    TreatmentPlanId = treatmentPlan.Id != null ? treatmentPlan.Id : (Guid?)null,
                    MedicalTestId = medicalTest.Id != null ? medicalTest.Id : (Guid?)null,
                    Talimatlar = prescription?.Instructions,
                    Açıklama = treatmentPlan?.Description,
                    //TedaviBitisTarihi = treatmentPlan?.TreatmentEndDate != null ? treatmentPlan.TreatmentEndDate.Value.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture) : null,
                    TestAdı = medicalTest?.TestName,
                    //TestTarihi = medicalTest?.TestDate != null ? medicalTest.TestDate.Value.ToShortDateString() : null,
                    Sonuç = medicalTest?.Result,
                    Notlar = medicalTest?.Notes,
                    Medications = string.Join(", ", prescription?.Medications ?? new List<string>())
                });
            }

            if (!treatmentInformation.Any())
            {
                MessageBox.Show("Veri listelenemedi.");
            }

            dgvPatientTreatmentInformation.DataSource = null;
            dgvPatientTreatmentInformation.DataSource = treatmentInformation;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPatientTreatmentInformation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek bir kayıt seçin.");
                return;
            }

            var selectedRow = dgvPatientTreatmentInformation.SelectedRows[0];
            var prescriptionId = selectedRow.Cells["PrescriptionId"].Value as Guid?;

            if (!prescriptionId.HasValue)
            {
                MessageBox.Show("Geçersiz reçete ID.");
                return;
            }

            var prescription = _prescriptionService.GetByID(prescriptionId.Value);
            if (prescription == null)
            {
                MessageBox.Show("Reçete bulunamadı.");
                return;
            }

            // Güncellenmiş bilgileri al
            prescription.Instructions = rtxtInstructions.Text;
            prescription.Medications = GetSelectedMedications();

            _prescriptionService.Update(prescription);

            var treatmentPlanId = selectedRow.Cells["TreatmentPlanId"].Value as Guid?;
            if (treatmentPlanId.HasValue)
            {
                var treatmentPlan = _treatmentPlanService.GetByID(treatmentPlanId.Value);
                if (treatmentPlan != null)
                {
                    treatmentPlan.Description = rtxtDescription.Text;
                    treatmentPlan.TreatmentEndDate = string.IsNullOrWhiteSpace(mtxtTreatmentEndDate.Text)
                        ? (DateTime?)null
                        : DateTime.ParseExact(mtxtTreatmentEndDate.Text, "dd.MM.yyyy", null);
                    _treatmentPlanService.Update(treatmentPlan);
                }
            }

            var medicalTestId = selectedRow.Cells["MedicalTestId"].Value as Guid?;
            if (medicalTestId.HasValue)
            {
                var medicalTest = _medicalTestService.GetByID(medicalTestId.Value);
                if (medicalTest != null)
                {
                    medicalTest.TestName = rtxtTestName.Text;
                    medicalTest.TestDate = string.IsNullOrWhiteSpace(mtxtTestDate.Text)
                        ? (DateTime?)null
                        : DateTime.ParseExact(mtxtTestDate.Text, "dd.MM.yyyy", null);
                    medicalTest.Result = rtxtResult.Text;
                    medicalTest.Notes = rtxtNotes.Text;
                    _medicalTestService.Update(medicalTest);
                }
            }

            MessageBox.Show("Kayıt başarıyla güncellendi.");
            PatientTreatmentInformationList(); // Güncellenmiş bilgileri tekrar yükleyin
        }












        //dotnet dev-certs https --trust



    }
}
