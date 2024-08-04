namespace HealthTrackingApp.UI
{
    partial class Frm_Appointment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpAppointmentSystem = new GroupBox();
            lblPatientSsn = new Label();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            cmbSpecialty = new ComboBox();
            label8 = new Label();
            btnAppointmentDelete = new Button();
            btnAppintmentUpdate = new Button();
            lblPatientFullName = new Label();
            label6 = new Label();
            cmbDoctorFullName = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpAppointmentDate = new DateTimePicker();
            label1 = new Label();
            btnAppointmentSave = new Button();
            btnPatientRegistrationPanel = new Button();
            dgvAppointmentList = new DataGridView();
            btnDoctorAppointmentCalendar = new Button();
            dgvDoctorAppointmentList = new DataGridView();
            btnPatientTreatmentInformation = new Button();
            grpAppointmentSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctorAppointmentList).BeginInit();
            SuspendLayout();
            // 
            // grpAppointmentSystem
            // 
            grpAppointmentSystem.BackColor = Color.PowderBlue;
            grpAppointmentSystem.Controls.Add(lblPatientSsn);
            grpAppointmentSystem.Controls.Add(button16);
            grpAppointmentSystem.Controls.Add(button15);
            grpAppointmentSystem.Controls.Add(button14);
            grpAppointmentSystem.Controls.Add(button13);
            grpAppointmentSystem.Controls.Add(button12);
            grpAppointmentSystem.Controls.Add(button11);
            grpAppointmentSystem.Controls.Add(button10);
            grpAppointmentSystem.Controls.Add(button9);
            grpAppointmentSystem.Controls.Add(button8);
            grpAppointmentSystem.Controls.Add(button7);
            grpAppointmentSystem.Controls.Add(button6);
            grpAppointmentSystem.Controls.Add(button5);
            grpAppointmentSystem.Controls.Add(button4);
            grpAppointmentSystem.Controls.Add(button3);
            grpAppointmentSystem.Controls.Add(button2);
            grpAppointmentSystem.Controls.Add(button1);
            grpAppointmentSystem.Controls.Add(cmbSpecialty);
            grpAppointmentSystem.Controls.Add(label8);
            grpAppointmentSystem.Controls.Add(btnAppointmentDelete);
            grpAppointmentSystem.Controls.Add(btnAppintmentUpdate);
            grpAppointmentSystem.Controls.Add(lblPatientFullName);
            grpAppointmentSystem.Controls.Add(label6);
            grpAppointmentSystem.Controls.Add(cmbDoctorFullName);
            grpAppointmentSystem.Controls.Add(label5);
            grpAppointmentSystem.Controls.Add(label3);
            grpAppointmentSystem.Controls.Add(label2);
            grpAppointmentSystem.Controls.Add(dtpAppointmentDate);
            grpAppointmentSystem.Controls.Add(label1);
            grpAppointmentSystem.Controls.Add(btnAppointmentSave);
            grpAppointmentSystem.Location = new Point(12, 12);
            grpAppointmentSystem.Name = "grpAppointmentSystem";
            grpAppointmentSystem.Size = new Size(657, 334);
            grpAppointmentSystem.TabIndex = 1;
            grpAppointmentSystem.TabStop = false;
            grpAppointmentSystem.Text = "Randevu Yönetim Sistemi";
            // 
            // lblPatientSsn
            // 
            lblPatientSsn.AutoSize = true;
            lblPatientSsn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPatientSsn.Location = new Point(143, 38);
            lblPatientSsn.Name = "lblPatientSsn";
            lblPatientSsn.Size = new Size(0, 20);
            lblPatientSsn.TabIndex = 48;
            // 
            // button16
            // 
            button16.Location = new Point(490, 79);
            button16.Name = "button16";
            button16.Size = new Size(46, 22);
            button16.TabIndex = 47;
            button16.Tag = "TimeSlot";
            button16.Text = "10:30";
            button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(542, 173);
            button15.Name = "button15";
            button15.Size = new Size(46, 22);
            button15.TabIndex = 46;
            button15.Tag = "TimeSlot";
            button15.Text = "17:00";
            button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(490, 173);
            button14.Name = "button14";
            button14.Size = new Size(46, 22);
            button14.TabIndex = 45;
            button14.Tag = "TimeSlot";
            button14.Text = "16:30";
            button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(438, 173);
            button13.Name = "button13";
            button13.Size = new Size(46, 22);
            button13.TabIndex = 44;
            button13.Tag = "TimeSlot";
            button13.Text = "16:00";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(386, 173);
            button12.Name = "button12";
            button12.Size = new Size(46, 22);
            button12.TabIndex = 43;
            button12.Tag = "TimeSlot";
            button12.Text = "15:30";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(542, 142);
            button11.Name = "button11";
            button11.Size = new Size(46, 22);
            button11.TabIndex = 42;
            button11.Tag = "TimeSlot";
            button11.Text = "15:00";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(490, 141);
            button10.Name = "button10";
            button10.Size = new Size(46, 22);
            button10.TabIndex = 41;
            button10.Tag = "TimeSlot";
            button10.Text = "14:30";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(438, 142);
            button9.Name = "button9";
            button9.Size = new Size(46, 22);
            button9.TabIndex = 40;
            button9.Tag = "TimeSlot";
            button9.Text = "14:00";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(386, 142);
            button8.Name = "button8";
            button8.Size = new Size(46, 22);
            button8.TabIndex = 39;
            button8.Tag = "TimeSlot";
            button8.Text = "13:30";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(540, 111);
            button7.Name = "button7";
            button7.Size = new Size(46, 22);
            button7.TabIndex = 38;
            button7.Tag = "TimeSlot";
            button7.Text = "13:00";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(488, 110);
            button6.Name = "button6";
            button6.Size = new Size(46, 22);
            button6.TabIndex = 37;
            button6.Tag = "TimeSlot";
            button6.Text = "12:30";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(438, 110);
            button5.Name = "button5";
            button5.Size = new Size(46, 22);
            button5.TabIndex = 36;
            button5.Tag = "TimeSlot";
            button5.Text = "12:00";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(386, 111);
            button4.Name = "button4";
            button4.Size = new Size(46, 22);
            button4.TabIndex = 35;
            button4.Tag = "TimeSlot";
            button4.Text = "11:30";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(542, 79);
            button3.Name = "button3";
            button3.Size = new Size(46, 22);
            button3.TabIndex = 34;
            button3.Tag = "TimeSlot";
            button3.Text = "11:00";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(438, 79);
            button2.Name = "button2";
            button2.Size = new Size(46, 22);
            button2.TabIndex = 33;
            button2.Tag = "TimeSlot";
            button2.Text = "10:00";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(386, 79);
            button1.Name = "button1";
            button1.Size = new Size(46, 22);
            button1.TabIndex = 32;
            button1.Tag = "TimeSlot";
            button1.Text = "09:30";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Location = new Point(143, 127);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(186, 23);
            cmbSpecialty.TabIndex = 31;
            cmbSpecialty.SelectedIndexChanged += cmbSpecialty_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 127);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 30;
            label8.Text = "Poliklinik Seçiniz :";
            // 
            // btnAppointmentDelete
            // 
            btnAppointmentDelete.Location = new Point(8, 279);
            btnAppointmentDelete.Name = "btnAppointmentDelete";
            btnAppointmentDelete.Size = new Size(209, 36);
            btnAppointmentDelete.TabIndex = 29;
            btnAppointmentDelete.Text = "Randevu Sil";
            btnAppointmentDelete.UseVisualStyleBackColor = true;
            btnAppointmentDelete.Click += btnAppointmentDelete_Click;
            // 
            // btnAppintmentUpdate
            // 
            btnAppintmentUpdate.Location = new Point(223, 279);
            btnAppintmentUpdate.Name = "btnAppintmentUpdate";
            btnAppintmentUpdate.Size = new Size(209, 38);
            btnAppintmentUpdate.TabIndex = 28;
            btnAppintmentUpdate.Text = "Randevu Güncelle";
            btnAppintmentUpdate.UseVisualStyleBackColor = true;
            btnAppintmentUpdate.Click += btnAppintmentUpdate_Click;
            // 
            // lblPatientFullName
            // 
            lblPatientFullName.AutoSize = true;
            lblPatientFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPatientFullName.Location = new Point(143, 82);
            lblPatientFullName.Name = "lblPatientFullName";
            lblPatientFullName.Size = new Size(0, 20);
            lblPatientFullName.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 38);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 25;
            label6.Text = "Hasta TC No :";
            // 
            // cmbDoctorFullName
            // 
            cmbDoctorFullName.FormattingEnabled = true;
            cmbDoctorFullName.Location = new Point(143, 168);
            cmbDoctorFullName.Name = "cmbDoctorFullName";
            cmbDoctorFullName.Size = new Size(186, 23);
            cmbDoctorFullName.TabIndex = 24;
            cmbDoctorFullName.SelectedIndexChanged += cmbDoctorFullName_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 84);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 23;
            label5.Text = "Hasta Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 168);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 20;
            label3.Text = "Doktor Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 48);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 16;
            label2.Text = "Randevu Saati :";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.Location = new Point(143, 215);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(186, 23);
            dtpAppointmentDate.TabIndex = 19;
            dtpAppointmentDate.ValueChanged += dtpAppointmentDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 221);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 17;
            label1.Text = "Randevu Tarihi :";
            // 
            // btnAppointmentSave
            // 
            btnAppointmentSave.Location = new Point(438, 279);
            btnAppointmentSave.Name = "btnAppointmentSave";
            btnAppointmentSave.Size = new Size(206, 36);
            btnAppointmentSave.TabIndex = 15;
            btnAppointmentSave.Text = "Randevu Al";
            btnAppointmentSave.UseVisualStyleBackColor = true;
            btnAppointmentSave.Click += btnAppointmentSave_Click;
            // 
            // btnPatientRegistrationPanel
            // 
            btnPatientRegistrationPanel.Location = new Point(675, 12);
            btnPatientRegistrationPanel.Name = "btnPatientRegistrationPanel";
            btnPatientRegistrationPanel.Size = new Size(371, 43);
            btnPatientRegistrationPanel.TabIndex = 2;
            btnPatientRegistrationPanel.Text = "Hasta Kayıt Paneli";
            btnPatientRegistrationPanel.UseVisualStyleBackColor = true;
            btnPatientRegistrationPanel.Click += btnPatientRegistrationPanel_Click;
            // 
            // dgvAppointmentList
            // 
            dgvAppointmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointmentList.BackgroundColor = SystemColors.Control;
            dgvAppointmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointmentList.Location = new Point(12, 352);
            dgvAppointmentList.Name = "dgvAppointmentList";
            dgvAppointmentList.Size = new Size(1034, 220);
            dgvAppointmentList.TabIndex = 3;
            // 
            // btnDoctorAppointmentCalendar
            // 
            btnDoctorAppointmentCalendar.Location = new Point(675, 106);
            btnDoctorAppointmentCalendar.Name = "btnDoctorAppointmentCalendar";
            btnDoctorAppointmentCalendar.Size = new Size(371, 38);
            btnDoctorAppointmentCalendar.TabIndex = 4;
            btnDoctorAppointmentCalendar.Text = "Doktor Randevu Takvimi";
            btnDoctorAppointmentCalendar.UseVisualStyleBackColor = true;
            btnDoctorAppointmentCalendar.Click += btnDoctorAppointmentCalendar_Click;
            // 
            // dgvDoctorAppointmentList
            // 
            dgvDoctorAppointmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctorAppointmentList.BackgroundColor = SystemColors.Control;
            dgvDoctorAppointmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctorAppointmentList.Location = new Point(675, 153);
            dgvDoctorAppointmentList.Name = "dgvDoctorAppointmentList";
            dgvDoctorAppointmentList.Size = new Size(371, 193);
            dgvDoctorAppointmentList.TabIndex = 5;
            // 
            // btnPatientTreatmentInformation
            // 
            btnPatientTreatmentInformation.Location = new Point(675, 60);
            btnPatientTreatmentInformation.Name = "btnPatientTreatmentInformation";
            btnPatientTreatmentInformation.Size = new Size(371, 40);
            btnPatientTreatmentInformation.TabIndex = 6;
            btnPatientTreatmentInformation.Text = "Hasta Tedavi Bilgileri";
            btnPatientTreatmentInformation.UseVisualStyleBackColor = true;
            btnPatientTreatmentInformation.Click += btnPatientTreatmentInformation_Click;
            // 
            // Frm_Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1095, 580);
            Controls.Add(btnPatientTreatmentInformation);
            Controls.Add(dgvDoctorAppointmentList);
            Controls.Add(btnDoctorAppointmentCalendar);
            Controls.Add(dgvAppointmentList);
            Controls.Add(btnPatientRegistrationPanel);
            Controls.Add(grpAppointmentSystem);
            Name = "Frm_Appointment";
            Text = "Form1";
            Load += Frm_Appointment_Load;
            grpAppointmentSystem.ResumeLayout(false);
            grpAppointmentSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctorAppointmentList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAppointmentSystem;
        private Button btnAppointmentDelete;
        private Button btnAppintmentUpdate;
        private Label label6;
        private ComboBox cmbDoctorFullName;
        private Label label5;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpAppointmentDate;
        private Label label1;
        private Button btnAppointmentSave;
        private Label label8;
        private Button button1;
        private ComboBox cmbSpecialty;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnPatientRegistrationPanel;
        private DataGridView dgvAppointmentList;
        private Button btnDoctorAppointmentCalendar;
        public Label lblPatientFullName;
        private Label lblPatientSsn;
        private DataGridView dgvDoctorAppointmentList;
        private Button btnPatientTreatmentInformation;
    }
}
