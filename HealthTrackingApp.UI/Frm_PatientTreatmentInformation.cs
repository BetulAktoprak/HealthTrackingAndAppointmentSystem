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
    public partial class Frm_PatientTreatmentInformation : Form
    {
        public Frm_PatientTreatmentInformation(string ssn, string fullName)
        {
            InitializeComponent();
            lblPatientSsn.Text = ssn;
            lblPatientFullName.Text = fullName;
        }

        private void Frm_PatientTreatmentInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
