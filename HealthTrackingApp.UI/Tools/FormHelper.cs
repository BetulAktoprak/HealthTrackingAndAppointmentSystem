namespace HealthTrackingApp.UI.Tools;

public class FormHelper
{
    public static void ClearForm(Control control)
    {
        ClearControls(control.Controls);
    }

    private static void ClearControls(Control.ControlCollection controls)
    {
        foreach (Control control in controls)
        {
            if (control is TextBox textBox)
            {
                textBox.Clear();
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.SelectedIndex = -1;
            }
            else if (control is RichTextBox richTextBox)
            {
                richTextBox.Clear();
            }
            else if (control is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Value = DateTime.Now;
            }
            else if (control is CheckBox checkBox)
            {
                checkBox.Checked = false;
            }
            else if (control.HasChildren)
            {
                ClearControls(control.Controls);
            }
        }
    }

    public static void ClearDataGridView(DataGridView dataGridView)
    {
        dataGridView.Rows.Clear();
    }
}
