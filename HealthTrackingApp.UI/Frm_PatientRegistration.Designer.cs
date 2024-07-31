namespace HealthTrackingApp.UI
{
    partial class Frm_PatientRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpPatientRegistration = new GroupBox();
            rbMarried = new RadioButton();
            rbSingle = new RadioButton();
            txtSsn = new TextBox();
            rtxtMedications = new RichTextBox();
            rtxtChronicDiseases = new RichTextBox();
            rtxtAllergies = new RichTextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            cmbBloodType = new ComboBox();
            label15 = new Label();
            txtPolicyNumber = new TextBox();
            label14 = new Label();
            txtInsuranceCompany = new TextBox();
            label13 = new Label();
            cmbInsuranceType = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            txtEmergencyPersonPhone = new TextBox();
            txtEmergencyPersonName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            rtxtMedicalHistory = new RichTextBox();
            dtpBirthDate = new DateTimePicker();
            cmbGender = new ComboBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            btnPatientDelete = new Button();
            btnPatientUpdate = new Button();
            btnPatientSave = new Button();
            dgvPatientList = new DataGridView();
            txtPatientSearch = new TextBox();
            label19 = new Label();
            btnCreatAppointment = new Button();
            label20 = new Label();
            grpPatientRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatientList).BeginInit();
            SuspendLayout();
            // 
            // grpPatientRegistration
            // 
            grpPatientRegistration.BackColor = Color.LightCoral;
            grpPatientRegistration.Controls.Add(rbMarried);
            grpPatientRegistration.Controls.Add(rbSingle);
            grpPatientRegistration.Controls.Add(txtSsn);
            grpPatientRegistration.Controls.Add(rtxtMedications);
            grpPatientRegistration.Controls.Add(rtxtChronicDiseases);
            grpPatientRegistration.Controls.Add(rtxtAllergies);
            grpPatientRegistration.Controls.Add(label18);
            grpPatientRegistration.Controls.Add(label17);
            grpPatientRegistration.Controls.Add(label16);
            grpPatientRegistration.Controls.Add(cmbBloodType);
            grpPatientRegistration.Controls.Add(label15);
            grpPatientRegistration.Controls.Add(txtPolicyNumber);
            grpPatientRegistration.Controls.Add(label14);
            grpPatientRegistration.Controls.Add(txtInsuranceCompany);
            grpPatientRegistration.Controls.Add(label13);
            grpPatientRegistration.Controls.Add(cmbInsuranceType);
            grpPatientRegistration.Controls.Add(label12);
            grpPatientRegistration.Controls.Add(label11);
            grpPatientRegistration.Controls.Add(txtEmergencyPersonPhone);
            grpPatientRegistration.Controls.Add(txtEmergencyPersonName);
            grpPatientRegistration.Controls.Add(label10);
            grpPatientRegistration.Controls.Add(label9);
            grpPatientRegistration.Controls.Add(label2);
            grpPatientRegistration.Controls.Add(rtxtMedicalHistory);
            grpPatientRegistration.Controls.Add(dtpBirthDate);
            grpPatientRegistration.Controls.Add(cmbGender);
            grpPatientRegistration.Controls.Add(txtEmail);
            grpPatientRegistration.Controls.Add(label7);
            grpPatientRegistration.Controls.Add(label6);
            grpPatientRegistration.Controls.Add(txtAddress);
            grpPatientRegistration.Controls.Add(label8);
            grpPatientRegistration.Controls.Add(txtPhone);
            grpPatientRegistration.Controls.Add(label5);
            grpPatientRegistration.Controls.Add(label4);
            grpPatientRegistration.Controls.Add(label3);
            grpPatientRegistration.Controls.Add(txtFullName);
            grpPatientRegistration.Controls.Add(label1);
            grpPatientRegistration.Location = new Point(29, 38);
            grpPatientRegistration.Name = "grpPatientRegistration";
            grpPatientRegistration.Size = new Size(1045, 370);
            grpPatientRegistration.TabIndex = 6;
            grpPatientRegistration.TabStop = false;
            grpPatientRegistration.Text = "Hasta Kayıt Formu";
            // 
            // rbMarried
            // 
            rbMarried.AutoSize = true;
            rbMarried.Location = new Point(203, 260);
            rbMarried.Name = "rbMarried";
            rbMarried.Size = new Size(43, 19);
            rbMarried.TabIndex = 27;
            rbMarried.TabStop = true;
            rbMarried.Text = "Evli";
            rbMarried.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            rbSingle.AutoSize = true;
            rbSingle.Location = new Point(122, 260);
            rbSingle.Name = "rbSingle";
            rbSingle.Size = new Size(54, 19);
            rbSingle.TabIndex = 26;
            rbSingle.TabStop = true;
            rbSingle.Text = "Bekar";
            rbSingle.UseVisualStyleBackColor = true;
            // 
            // txtSsn
            // 
            txtSsn.Location = new Point(122, 30);
            txtSsn.Name = "txtSsn";
            txtSsn.Size = new Size(183, 23);
            txtSsn.TabIndex = 25;
            // 
            // rtxtMedications
            // 
            rtxtMedications.Location = new Point(438, 165);
            rtxtMedications.Name = "rtxtMedications";
            rtxtMedications.Size = new Size(202, 55);
            rtxtMedications.TabIndex = 24;
            rtxtMedications.Text = "";
            // 
            // rtxtChronicDiseases
            // 
            rtxtChronicDiseases.Location = new Point(438, 101);
            rtxtChronicDiseases.Name = "rtxtChronicDiseases";
            rtxtChronicDiseases.Size = new Size(202, 50);
            rtxtChronicDiseases.TabIndex = 23;
            rtxtChronicDiseases.Text = "";
            // 
            // rtxtAllergies
            // 
            rtxtAllergies.Location = new Point(438, 33);
            rtxtAllergies.Name = "rtxtAllergies";
            rtxtAllergies.Size = new Size(202, 50);
            rtxtAllergies.TabIndex = 23;
            rtxtAllergies.Text = "";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(315, 168);
            label18.Name = "label18";
            label18.Size = new Size(100, 15);
            label18.TabIndex = 22;
            label18.Text = "Kullandığı İlaçlar :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(315, 104);
            label17.Name = "label17";
            label17.Size = new Size(105, 15);
            label17.TabIndex = 21;
            label17.Text = "Kronik Hastalıklar :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(367, 41);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 20;
            label16.Text = "Alerjiler :";
            // 
            // cmbBloodType
            // 
            cmbBloodType.FormattingEnabled = true;
            cmbBloodType.Location = new Point(103, 298);
            cmbBloodType.Name = "cmbBloodType";
            cmbBloodType.Size = new Size(202, 23);
            cmbBloodType.TabIndex = 19;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1, 298);
            label15.Name = "label15";
            label15.Size = new Size(69, 15);
            label15.TabIndex = 18;
            label15.Text = "Kan Grubu :";
            // 
            // txtPolicyNumber
            // 
            txtPolicyNumber.Location = new Point(811, 186);
            txtPolicyNumber.Name = "txtPolicyNumber";
            txtPolicyNumber.Size = new Size(183, 23);
            txtPolicyNumber.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(688, 194);
            label14.Name = "label14";
            label14.Size = new Size(99, 15);
            label14.TabIndex = 16;
            label14.Text = "Poliçe Numarası :";
            // 
            // txtInsuranceCompany
            // 
            txtInsuranceCompany.Location = new Point(811, 149);
            txtInsuranceCompany.Name = "txtInsuranceCompany";
            txtInsuranceCompany.Size = new Size(183, 23);
            txtInsuranceCompany.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(688, 157);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 16;
            label13.Text = "Sigorta Şirketi :";
            // 
            // cmbInsuranceType
            // 
            cmbInsuranceType.FormattingEnabled = true;
            cmbInsuranceType.Location = new Point(811, 115);
            cmbInsuranceType.Name = "cmbInsuranceType";
            cmbInsuranceType.Size = new Size(183, 23);
            cmbInsuranceType.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(688, 123);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 14;
            label12.Text = "Sigorta Türü :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(689, 79);
            label11.Name = "label11";
            label11.Size = new Size(111, 15);
            label11.TabIndex = 13;
            label11.Text = "Acil Kişi Numarası : ";
            // 
            // txtEmergencyPersonPhone
            // 
            txtEmergencyPersonPhone.Location = new Point(811, 71);
            txtEmergencyPersonPhone.Name = "txtEmergencyPersonPhone";
            txtEmergencyPersonPhone.Size = new Size(183, 23);
            txtEmergencyPersonPhone.TabIndex = 12;
            // 
            // txtEmergencyPersonName
            // 
            txtEmergencyPersonName.Location = new Point(811, 33);
            txtEmergencyPersonName.Name = "txtEmergencyPersonName";
            txtEmergencyPersonName.Size = new Size(183, 23);
            txtEmergencyPersonName.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(689, 41);
            label10.Name = "label10";
            label10.Size = new Size(117, 15);
            label10.TabIndex = 10;
            label10.Text = "Acil Durum Kişi (Ad):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 260);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 8;
            label9.Text = "Medeni Hali :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 38);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "TC No :";
            // 
            // rtxtMedicalHistory
            // 
            rtxtMedicalHistory.Location = new Point(438, 257);
            rtxtMedicalHistory.Name = "rtxtMedicalHistory";
            rtxtMedicalHistory.Size = new Size(556, 107);
            rtxtMedicalHistory.TabIndex = 6;
            rtxtMedicalHistory.Text = "";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(122, 88);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(183, 23);
            dtpBirthDate.TabIndex = 4;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(122, 120);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(183, 23);
            cmbGender.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 181);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 260);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 1;
            label7.Text = "Sağlık Geçmişi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 189);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 1;
            label6.Text = "E-posta :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(122, 213);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(183, 23);
            txtAddress.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 221);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 1;
            label8.Text = "Adres :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(122, 149);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 23);
            txtPhone.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 157);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 1;
            label5.Text = "Telefon No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 128);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 1;
            label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 96);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 1;
            label3.Text = "Doğum Tarihi :";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(122, 59);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(183, 23);
            txtFullName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 67);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Adı ve Soyadı :";
            // 
            // btnPatientDelete
            // 
            btnPatientDelete.Location = new Point(1109, 207);
            btnPatientDelete.Name = "btnPatientDelete";
            btnPatientDelete.Size = new Size(238, 57);
            btnPatientDelete.TabIndex = 29;
            btnPatientDelete.Text = "Sil";
            btnPatientDelete.UseVisualStyleBackColor = true;
            btnPatientDelete.Click += btnPatientDelete_Click;
            // 
            // btnPatientUpdate
            // 
            btnPatientUpdate.Location = new Point(1109, 125);
            btnPatientUpdate.Name = "btnPatientUpdate";
            btnPatientUpdate.Size = new Size(238, 52);
            btnPatientUpdate.TabIndex = 28;
            btnPatientUpdate.Text = "Düzenle";
            btnPatientUpdate.UseVisualStyleBackColor = true;
            btnPatientUpdate.Click += btnPatientUpdate_Click;
            // 
            // btnPatientSave
            // 
            btnPatientSave.Location = new Point(1109, 38);
            btnPatientSave.Name = "btnPatientSave";
            btnPatientSave.Size = new Size(238, 58);
            btnPatientSave.TabIndex = 0;
            btnPatientSave.Text = "Kaydet";
            btnPatientSave.UseVisualStyleBackColor = true;
            btnPatientSave.Click += btnPatientSave_Click;
            // 
            // dgvPatientList
            // 
            dgvPatientList.BackgroundColor = SystemColors.Window;
            dgvPatientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientList.Location = new Point(29, 414);
            dgvPatientList.Name = "dgvPatientList";
            dgvPatientList.Size = new Size(1333, 214);
            dgvPatientList.TabIndex = 7;
            dgvPatientList.CellDoubleClick += dgvPatientList_CellDoubleClick;
            dgvPatientList.MouseClick += dgvPatientList_MouseClick;
            // 
            // txtPatientSearch
            // 
            txtPatientSearch.Location = new Point(1109, 371);
            txtPatientSearch.Name = "txtPatientSearch";
            txtPatientSearch.Size = new Size(238, 23);
            txtPatientSearch.TabIndex = 30;
            txtPatientSearch.TextChanged += txtPatientSearch_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label19.Location = new Point(1109, 343);
            label19.Name = "label19";
            label19.Size = new Size(91, 21);
            label19.TabIndex = 31;
            label19.Text = "Hasta Ara :";
            // 
            // btnCreatAppointment
            // 
            btnCreatAppointment.Location = new Point(1109, 285);
            btnCreatAppointment.Name = "btnCreatAppointment";
            btnCreatAppointment.Size = new Size(238, 49);
            btnCreatAppointment.TabIndex = 32;
            btnCreatAppointment.Text = "Randevu Oluştur";
            btnCreatAppointment.UseVisualStyleBackColor = true;
            btnCreatAppointment.Click += btnCreatAppointment_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(69, 9);
            label20.Name = "label20";
            label20.Size = new Size(295, 15);
            label20.TabIndex = 33;
            label20.Text = "Lütfen Randevu Oluşturmak İstediğiniz Hastayı Seçiniz.";
            // 
            // Frm_PatientRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1399, 640);
            Controls.Add(label20);
            Controls.Add(btnCreatAppointment);
            Controls.Add(label19);
            Controls.Add(txtPatientSearch);
            Controls.Add(btnPatientDelete);
            Controls.Add(dgvPatientList);
            Controls.Add(btnPatientUpdate);
            Controls.Add(grpPatientRegistration);
            Controls.Add(btnPatientSave);
            Name = "Frm_PatientRegistration";
            Text = "Frm_PatientRegistration";
            Load += Frm_PatientRegistration_Load;
            grpPatientRegistration.ResumeLayout(false);
            grpPatientRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatientList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpPatientRegistration;
        private RadioButton rbMarried;
        private RadioButton rbSingle;
        private TextBox txtSsn;
        private RichTextBox rtxtMedications;
        private RichTextBox rtxtChronicDiseases;
        private RichTextBox rtxtAllergies;
        private Label label18;
        private Label label17;
        private Label label16;
        private ComboBox cmbBloodType;
        private Label label15;
        private TextBox txtPolicyNumber;
        private Label label14;
        private TextBox txtInsuranceCompany;
        private Label label13;
        private ComboBox cmbInsuranceType;
        private Label label12;
        private Label label11;
        private TextBox txtEmergencyPersonPhone;
        private TextBox txtEmergencyPersonName;
        private Label label10;
        private Label label9;
        private Label label2;
        private RichTextBox rtxtMedicalHistory;
        private DateTimePicker dtpBirthDate;
        private ComboBox cmbGender;
        private TextBox txtEmail;
        private Label label7;
        private Label label6;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtPhone;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtFullName;
        private Label label1;
        private Button btnPatientSave;
        private DataGridView dgvPatientList;
        private Button btnPatientDelete;
        private Button btnPatientUpdate;
        private TextBox txtPatientSearch;
        private Label label19;
        private Button btnCreatAppointment;
        private Label label20;
    }
}