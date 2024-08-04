namespace HealthTrackingApp.UI
{
    partial class Frm_DoctorLogin
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
            grpDoctorLogin = new GroupBox();
            btnIntroduction = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtDoctorFullName = new TextBox();
            label1 = new Label();
            grpDoctorLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpDoctorLogin
            // 
            grpDoctorLogin.BackColor = SystemColors.Control;
            grpDoctorLogin.Controls.Add(btnIntroduction);
            grpDoctorLogin.Controls.Add(txtPassword);
            grpDoctorLogin.Controls.Add(label2);
            grpDoctorLogin.Controls.Add(txtDoctorFullName);
            grpDoctorLogin.Controls.Add(label1);
            grpDoctorLogin.Location = new Point(263, 60);
            grpDoctorLogin.Name = "grpDoctorLogin";
            grpDoctorLogin.Size = new Size(416, 267);
            grpDoctorLogin.TabIndex = 0;
            grpDoctorLogin.TabStop = false;
            grpDoctorLogin.Text = "Doktor Giriş Ekranı";
            // 
            // btnIntroduction
            // 
            btnIntroduction.Location = new Point(184, 187);
            btnIntroduction.Name = "btnIntroduction";
            btnIntroduction.Size = new Size(94, 35);
            btnIntroduction.TabIndex = 2;
            btnIntroduction.Text = "Giriş";
            btnIntroduction.UseVisualStyleBackColor = true;
            btnIntroduction.Click += btnIntroduction_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(139, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(212, 23);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 126);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 0;
            label2.Text = "Şİfre :";
            // 
            // txtDoctorFullName
            // 
            txtDoctorFullName.Location = new Point(139, 70);
            txtDoctorFullName.Name = "txtDoctorFullName";
            txtDoctorFullName.Size = new Size(212, 23);
            txtDoctorFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 73);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            // 
            // Frm_DoctorLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1025, 532);
            Controls.Add(grpDoctorLogin);
            Name = "Frm_DoctorLogin";
            Text = "Frm_DoctorLogin";
            Load += Frm_DoctorLogin_Load;
            grpDoctorLogin.ResumeLayout(false);
            grpDoctorLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDoctorLogin;
        private TextBox txtDoctorFullName;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private Button btnIntroduction;
    }
}