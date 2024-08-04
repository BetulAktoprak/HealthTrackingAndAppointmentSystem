using HealthTrackingApp.Business.Services;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;
using HealthTrackingApp.UI.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HealthTrackingApp.UI
{
    public partial class Frm_PatientRegistration : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly PatientService _patientService;
        private readonly InsuranceInformationService _insuranceInformationService;
        public Frm_PatientRegistration()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            PatientRepository pRepo = new PatientRepository(_context);
            _patientService = new PatientService(pRepo);
            InsuranceInformationRepository iRepo = new InsuranceInformationRepository(_context);
            _insuranceInformationService = new InsuranceInformationService(iRepo);

        }

        private void Frm_PatientRegistration_Load(object sender, EventArgs e)
        {
            PatientGender();
            BloodGroups();
            InsuranceType();
            PatientList();

        }

        private void PatientList()
        {
            dgvPatientList.DataSource = null;
            dgvPatientList.DataSource = _patientService.GetAll();
        }

        private void InsuranceType()
        {
            cmbInsuranceType.Items.Add("Genel Sağlık Sigortası (GSS)");
            cmbInsuranceType.Items.Add("Bağ-Kur");
            cmbInsuranceType.Items.Add("SSK (Sosyal Sigortalar Kurumu)");
            cmbInsuranceType.Items.Add("Emekli Sandığı");
            cmbInsuranceType.Items.Add("Yeşil Kart");
            cmbInsuranceType.Items.Add("Özel Sağlık Sigortası");
            cmbInsuranceType.Items.Add("Zorunlu Trafik Sigortası");
        }

        private void BloodGroups()
        {
            cmbBloodType.Items.Add("A Rh(+)");
            cmbBloodType.Items.Add("A Rh(-)");
            cmbBloodType.Items.Add("B Rh(+)");
            cmbBloodType.Items.Add("B Rh(-)");
            cmbBloodType.Items.Add("AB Rh(+)");
            cmbBloodType.Items.Add("AB Rh(-)");
            cmbBloodType.Items.Add("0 Rh(+)");
            cmbBloodType.Items.Add("0 Rh(-)");
        }

        private void PatientGender()
        {
            cmbGender.Items.Add("Erkek");
            cmbGender.Items.Add("Kadın");
            cmbGender.Items.Add("Diğer");

        }

        private void btnPatientSave_Click(object sender, EventArgs e)
        {
            try
            {
                string maritalStatus = GetSelectedMaritalStatus();

                Patient patient = new Patient()
                {
                    SSN = txtSsn.Text,
                    FullName = txtFullName.Text,
                    BirthDate = DateTime.Parse(dtpBirthDate.Text),
                    Gender = cmbGender.SelectedItem.ToString(),
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    MaritalStatus = maritalStatus,
                    EmergencyContactPerson = txtEmergencyPersonName.Text,
                    EmergencyContactNumber = txtEmergencyPersonPhone.Text,
                    MedicalHistory = rtxtMedicalHistory.Text,
                    BloodType = cmbBloodType.SelectedItem.ToString(),
                    Allergies = rtxtAllergies.Text,
                    ChronicDiseases = rtxtChronicDiseases.Text,
                    Medications = rtxtMedications.Text
                };

                _patientService.Add(patient);
                var patientId = _patientService.GetIdBySsn(patient.SSN);

                InsuranceInformation insuranceInformation = new InsuranceInformation()
                {
                    PatientId = patientId,
                    InsuranceType = cmbInsuranceType.SelectedItem.ToString(),
                    InsuranceCompany = txtInsuranceCompany.Text,
                    PolicyNumber = txtPolicyNumber.Text
                };

                _insuranceInformationService.Add(insuranceInformation);

                MessageBox.Show("Hasta kayıt edildi.");
                FormHelper.ClearForm(this);
                PatientList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu : " + ex.Message);
            }
        }
        public string GetSelectedMaritalStatus()
        {
            if (rbSingle.Checked)
            {
                return "Bekar";
            }
            else if (rbMarried.Checked)
            {
                return "Evli";
            }
            return string.Empty;
        }
        private void dgvPatientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPatientList.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPatientList.SelectedRows[0];


                txtSsn.Text = selectedRow.Cells["SSN"].Value.ToString();
                txtFullName.Text = selectedRow.Cells["FullName"].Value.ToString();
                dtpBirthDate.Text = selectedRow.Cells["BirthDate"].Value.ToString();
                cmbGender.SelectedItem = selectedRow.Cells["Gender"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                if (selectedRow.Cells["MaritalStatus"].Value.ToString() == "Bekar")
                {
                    rbSingle.Checked = true;
                }
                else if (selectedRow.Cells["MaritalStatus"].Value.ToString() == "Evli")
                {
                    rbMarried.Checked = true;
                }
                txtEmergencyPersonName.Text = selectedRow.Cells["EmergencyContactPerson"].Value.ToString();
                txtEmergencyPersonPhone.Text = selectedRow.Cells["EmergencyContactNumber"].Value.ToString();
                rtxtMedicalHistory.Text = selectedRow.Cells["MedicalHistory"].Value.ToString();
                cmbBloodType.SelectedItem = selectedRow.Cells["BloodType"].Value.ToString();
                rtxtAllergies.Text = selectedRow.Cells["Allergies"].Value.ToString();
                rtxtChronicDiseases.Text = selectedRow.Cells["ChronicDiseases"].Value.ToString();
                rtxtMedications.Text = selectedRow.Cells["Medications"].Value.ToString();


                Guid patientId = (Guid)selectedRow.Cells["Id"].Value;
                InsuranceInformation insuranceInformation = _insuranceInformationService.GetByPatientId(patientId);

                cmbInsuranceType.SelectedItem = insuranceInformation.InsuranceType;
                txtInsuranceCompany.Text = insuranceInformation.InsuranceCompany;
                txtPolicyNumber.Text = insuranceInformation.PolicyNumber;
            }
        }

        private void btnPatientUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPatientId = GetSelectedPatientId();

                if (selectedPatientId == null)
                {
                    MessageBox.Show("Lütfen güncellemek için bir hasta seçin.");
                    return;
                }

                var patient = _patientService.GetByID(selectedPatientId.Value);

                patient.SSN = txtSsn.Text;
                patient.FullName = txtFullName.Text;
                patient.BirthDate = DateTime.Parse(dtpBirthDate.Text);
                patient.Gender = cmbGender.SelectedItem.ToString();
                patient.Phone = txtPhone.Text;
                patient.Email = txtEmail.Text;
                patient.Address = txtAddress.Text;
                patient.MaritalStatus = GetSelectedMaritalStatus();
                patient.EmergencyContactPerson = txtEmergencyPersonName.Text;
                patient.EmergencyContactNumber = txtEmergencyPersonPhone.Text;
                patient.MedicalHistory = rtxtMedicalHistory.Text;
                patient.BloodType = cmbBloodType.SelectedItem.ToString();
                patient.Allergies = rtxtAllergies.Text;
                patient.ChronicDiseases = rtxtChronicDiseases.Text;
                patient.Medications = rtxtMedications.Text;


                _patientService.Update(patient);

                var insuranceInformation = _insuranceInformationService.GetByPatientId(selectedPatientId.Value);

                insuranceInformation.InsuranceType = cmbInsuranceType.SelectedItem.ToString();
                insuranceInformation.InsuranceCompany = txtInsuranceCompany.Text;
                insuranceInformation.PolicyNumber = txtPolicyNumber.Text;


                _insuranceInformationService.Update(insuranceInformation);

                MessageBox.Show("Hasta bilgileri güncellendi.");

                FormHelper.ClearForm(this);
                PatientList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu : " + ex.Message);
            }
        }

        private Guid? GetSelectedPatientId()
        {
            if (dgvPatientList.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPatientList.SelectedRows[0];
                return (Guid?)selectedRow.Cells["Id"].Value;
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta seçiniz.");
            }
            return null;
        }


        private void btnPatientDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var patientId = GetSelectedPatientId();
                _patientService.Delete(patientId.Value);

                MessageBox.Show("Hasta silindi.");
                FormHelper.ClearForm(this);
                PatientList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu : " + ex.Message);
            }
        }

        private void txtPatientSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtPatientSearch.Text.ToLower();

            if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 2)
            {
                var filteredPatients = _patientService.GetAll()
                    .Where(p => p.FullName.ToLower().Contains(searchText) ||
                    p.SSN.ToLower().Contains(searchText))
                    .ToList();

                dgvPatientList.DataSource = filteredPatients;
            }
            else if (searchText.Length == 0)
            {
                PatientList();
            }
        }


        private string selectedPatientSsn;
        private string selectedPatientFullName;
        private void dgvPatientList_MouseClick(object sender, MouseEventArgs e)
        {

            if (dgvPatientList.CurrentRow != null)
            {
                string ssn = dgvPatientList.CurrentRow.Cells["SSN"].Value?.ToString();
                string fullName = dgvPatientList.CurrentRow.Cells["FullName"].Value?.ToString();

                selectedPatientSsn = ssn;
                selectedPatientFullName = fullName;
            }
        }
        private void btnCreatAppointment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedPatientSsn) && !string.IsNullOrEmpty(selectedPatientFullName))
            {
                Frm_Appointment frm_Appointment = new Frm_Appointment(selectedPatientSsn, selectedPatientFullName);
                frm_Appointment.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta seçiniz. ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
