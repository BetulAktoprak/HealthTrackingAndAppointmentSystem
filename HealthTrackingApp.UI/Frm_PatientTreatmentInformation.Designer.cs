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
            groupBox1 = new GroupBox();
            lblPatientSsn = new Label();
            lblPatientFullName = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPatientSsn);
            groupBox1.Controls.Add(lblPatientFullName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(59, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblPatientSsn
            // 
            lblPatientSsn.AutoSize = true;
            lblPatientSsn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPatientSsn.Location = new Point(179, 42);
            lblPatientSsn.Name = "lblPatientSsn";
            lblPatientSsn.Size = new Size(0, 20);
            lblPatientSsn.TabIndex = 52;
            // 
            // lblPatientFullName
            // 
            lblPatientFullName.AutoSize = true;
            lblPatientFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPatientFullName.Location = new Point(179, 72);
            lblPatientFullName.Name = "lblPatientFullName";
            lblPatientFullName.Size = new Size(0, 20);
            lblPatientFullName.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 42);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 50;
            label6.Text = "Hasta TC No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 74);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 49;
            label5.Text = "Hasta Adı :";
            // 
            // Frm_PatientTreatmentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 516);
            Controls.Add(groupBox1);
            Name = "Frm_PatientTreatmentInformation";
            Text = "Frm_PatientTreatmentInformation";
            Load += Frm_PatientTreatmentInformation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblPatientSsn;
        public Label lblPatientFullName;
        private Label label6;
        private Label label5;
    }
}