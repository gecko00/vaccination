using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vaccination
{
    public partial class FormSearchGroups : Form
    {
        // Строковая переменная для хранения текста фильтра
        public string filter;

        // Текущая дата
        DateTime CurrentTime = DateTime.Now;

        // Переменные для компонентов фильтра
        string admissionYear = "";
        string graduationYear = "";

        // Устанавливает доступные года для NumericUpDown
        void setAvailableYears(NumericUpDown numeric)
        {
            numeric.Minimum = 2010;
            numeric.Maximum = Convert.ToInt32(CurrentTime.Year) + 4;
        }
        

        public FormSearchGroups()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (checkBoxAdmissionYear.Checked == true)
            {
                admissionYear = "admissionYear = " + numericUpDownAdmissionYear.Value.ToString();
            }

            if (checkBoxGraduationYear.Checked == true)
            {
                graduationYear = "graduationYear = " + numericUpDownGraduationYear.Value.ToString();
            }

            // Складывание фильтра
            filter = admissionYear;

            if (filter != "" & admissionYear != "")
                filter = filter + " and ";
            filter = filter + graduationYear;

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxAdmissionYear_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownAdmissionYear.Enabled = checkBoxAdmissionYear.Checked;
        }

        private void checkBoxGraduationYear_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownGraduationYear.Enabled = checkBoxGraduationYear.Checked;
        }

        private void FormSearchGroups_Load(object sender, EventArgs e)
        {
            setAvailableYears(numericUpDownAdmissionYear);
            setAvailableYears(numericUpDownGraduationYear);
        }
    }
}
