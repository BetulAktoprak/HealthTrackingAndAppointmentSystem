namespace HealthTrackingApp.UI
{
    partial class Frm_PatientTreatmentInformation
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
            medicationList = new CheckedListBox();
            grpPatientTreatmentInformation = new GroupBox();
            btnUpdate = new Button();
            btnSave = new Button();
            rtxtNotes = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            mtxtTestDate = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            mtxtTreatmentEndDate = new MaskedTextBox();
            rtxtTestName = new RichTextBox();
            rtxtResult = new RichTextBox();
            label11 = new Label();
            rtxtDescription = new RichTextBox();
            label3 = new Label();
            rtxtInstructions = new RichTextBox();
            lblIntroduction = new Label();
            lblPatientSsn = new Label();
            lblPatientFullName = new Label();
            label9 = new Label();
            label10 = new Label();
            txtSearch = new TextBox();
            label6 = new Label();
            dgvPatientTreatmentInformation = new DataGridView();
            grpPatientTreatmentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatientTreatmentInformation).BeginInit();
            SuspendLayout();
            // 
            // medicationList
            // 
            medicationList.FormattingEnabled = true;
            medicationList.Location = new Point(854, 68);
            medicationList.Name = "medicationList";
            medicationList.Size = new Size(329, 274);
            medicationList.TabIndex = 1;
            // 
            // grpPatientTreatmentInformation
            // 
            grpPatientTreatmentInformation.BackColor = Color.LightBlue;
            grpPatientTreatmentInformation.Controls.Add(btnUpdate);
            grpPatientTreatmentInformation.Controls.Add(btnSave);
            grpPatientTreatmentInformation.Controls.Add(rtxtNotes);
            grpPatientTreatmentInformation.Controls.Add(label5);
            grpPatientTreatmentInformation.Controls.Add(label4);
            grpPatientTreatmentInformation.Controls.Add(mtxtTestDate);
            grpPatientTreatmentInformation.Controls.Add(label2);
            grpPatientTreatmentInformation.Controls.Add(label1);
            grpPatientTreatmentInformation.Controls.Add(mtxtTreatmentEndDate);
            grpPatientTreatmentInformation.Controls.Add(rtxtTestName);
            grpPatientTreatmentInformation.Controls.Add(rtxtResult);
            grpPatientTreatmentInformation.Controls.Add(label11);
            grpPatientTreatmentInformation.Controls.Add(rtxtDescription);
            grpPatientTreatmentInformation.Controls.Add(label3);
            grpPatientTreatmentInformation.Controls.Add(rtxtInstructions);
            grpPatientTreatmentInformation.Controls.Add(lblIntroduction);
            grpPatientTreatmentInformation.Controls.Add(lblPatientSsn);
            grpPatientTreatmentInformation.Controls.Add(lblPatientFullName);
            grpPatientTreatmentInformation.Controls.Add(label9);
            grpPatientTreatmentInformation.Controls.Add(label10);
            grpPatientTreatmentInformation.Location = new Point(59, 12);
            grpPatientTreatmentInformation.Name = "grpPatientTreatmentInformation";
            grpPatientTreatmentInformation.Size = new Size(770, 338);
            grpPatientTreatmentInformation.TabIndex = 0;
            grpPatientTreatmentInformation.TabStop = false;
            grpPatientTreatmentInformation.Text = "Hasta Tedavi Bilgileri";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(377, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(166, 42);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(568, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 42);
            btnSave.TabIndex = 62;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(528, 214);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(206, 67);
            rtxtNotes.TabIndex = 61;
            rtxtNotes.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 217);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 60;
            label5.Text = "Notlar :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 95);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 59;
            label4.Text = "Test Tarihi :";
            // 
            // mtxtTestDate
            // 
            mtxtTestDate.Location = new Point(528, 89);
            mtxtTestDate.Name = "mtxtTestDate";
            mtxtTestDate.Size = new Size(206, 23);
            mtxtTestDate.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 29);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 57;
            label2.Text = "Test Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 261);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 56;
            label1.Text = "Tedavi Bitiş Tarihi :";
            // 
            // mtxtTreatmentEndDate
            // 
            mtxtTreatmentEndDate.Location = new Point(171, 258);
            mtxtTreatmentEndDate.Name = "mtxtTreatmentEndDate";
            mtxtTreatmentEndDate.Size = new Size(192, 23);
            mtxtTreatmentEndDate.TabIndex = 55;
            // 
            // rtxtTestName
            // 
            rtxtTestName.Location = new Point(528, 26);
            rtxtTestName.Name = "rtxtTestName";
            rtxtTestName.Size = new Size(206, 50);
            rtxtTestName.TabIndex = 54;
            rtxtTestName.Text = "";
            // 
            // rtxtResult
            // 
            rtxtResult.Location = new Point(528, 132);
            rtxtResult.Name = "rtxtResult";
            rtxtResult.Size = new Size(206, 66);
            rtxtResult.TabIndex = 54;
            rtxtResult.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(423, 132);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 53;
            label11.Text = "Sonuçlar :";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(157, 178);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(206, 66);
            rtxtDescription.TabIndex = 54;
            rtxtDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 181);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 53;
            label3.Text = "Açıklama :";
            // 
            // rtxtInstructions
            // 
            rtxtInstructions.Location = new Point(157, 89);
            rtxtInstructions.Name = "rtxtInstructions";
            rtxtInstructions.Size = new Size(206, 71);
            rtxtInstructions.TabIndex = 54;
            rtxtInstructions.Text = "";
            // 
            // lblIntroduction
            // 
            lblIntroduction.AutoSize = true;
            lblIntroduction.Location = new Point(50, 89);
            lblIntroduction.Name = "lblIntroduction";
            lblIntroduction.Size = new Size(64, 15);
            lblIntroduction.TabIndex = 53;
            lblIntroduction.Text = "Talimatlar :";
            // 
            // lblPatientSsn
            // 
            lblPatientSsn.AutoSize = true;
            lblPatientSsn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPatientSsn.Location = new Point(157, 26);
            lblPatientSsn.Name = "lblPatientSsn";
            lblPatientSsn.Size = new Size(0, 20);
            lblPatientSsn.TabIndex = 52;
            // 
            // lblPatientFullName
            // 
            lblPatientFullName.AutoSize = true;
            lblPatientFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPatientFullName.Location = new Point(157, 56);
            lblPatientFullName.Name = "lblPatientFullName";
            lblPatientFullName.Size = new Size(0, 20);
            lblPatientFullName.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 30);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 50;
            label9.Text = "Hasta TC No :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 58);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 49;
            label10.Text = "Hasta Adı :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(945, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(238, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(854, 30);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 3;
            label6.Text = "İlaç ismini ara :";
            // 
            // dgvPatientTreatmentInformation
            // 
            dgvPatientTreatmentInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatientTreatmentInformation.BackgroundColor = SystemColors.Control;
            dgvPatientTreatmentInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientTreatmentInformation.Location = new Point(59, 368);
            dgvPatientTreatmentInformation.Name = "dgvPatientTreatmentInformation";
            dgvPatientTreatmentInformation.Size = new Size(1124, 196);
            dgvPatientTreatmentInformation.TabIndex = 4;
            dgvPatientTreatmentInformation.SelectionChanged += dgvPatientTreatmentInformation_SelectionChanged;
            // 
            // Frm_PatientTreatmentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1210, 576);
            Controls.Add(dgvPatientTreatmentInformation);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(medicationList);
            Controls.Add(grpPatientTreatmentInformation);
            Name = "Frm_PatientTreatmentInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_PatientTreatmentInformation";
            Load += Frm_PatientTreatmentInformation_Load;
            grpPatientTreatmentInformation.ResumeLayout(false);
            grpPatientTreatmentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatientTreatmentInformation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox medicationList;
        private GroupBox grpPatientTreatmentInformation;
        private RichTextBox rtxtResult;
        private Label label11;
        private RichTextBox rtxtDescription;
        private Label label3;
        private RichTextBox rtxtInstructions;
        private Label lblIntroduction;
        private Label lblPatientSsn;
        public Label lblPatientFullName;
        private Label label9;
        private Label label10;
        private Label label1;
        private MaskedTextBox mtxtTreatmentEndDate;
        private RichTextBox rtxtNotes;
        private Label label5;
        private Label label4;
        private MaskedTextBox mtxtTestDate;
        private Label label2;
        private RichTextBox rtxtTestName;
        private TextBox txtSearch;
        private Label label6;
        private DataGridView dgvPatientTreatmentInformation;
        private Button button2;
        private Button btnSave;
        private Button btnUpdate;
    }
}