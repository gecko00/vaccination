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
    public partial class FormSearchStudentsForDisplay : Form
    {
        // Строковая переменная для хранения текста фильтра
        public string filter;

        // Текущая дата
        DateTime CurrentTime = DateTime.Now;

        // Переменные для компонентов фильтра
        string lastName = "";
        string group = "";
        string healthGroup = "";
        string status = "";
        string age = "";

        // Флаг возраст до/ровно

        public FormSearchStudentsForDisplay()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (checkBoxLastName.Checked == true)
            {
                lastName = "studentLastName = '" + textBoxLastName.Text + "'";
            }

            if (checkBoxGroup.Checked == true)
            {
                group = "groupNo = '" + comboBoxGroup.Text + "'";
            }

            if (checkBoxHealthGroup.Checked == true)
            {
                healthGroup = "physicalEducationHealthGroupName = '" + comboBoxHealthGroup.Text + "'";
            }

            if (checkBoxStatus.Checked == true)
            {
                status = "studentStatusName = '" + comboBoxStatus.Text + "'";
            }

            if (checkBoxAge.Checked == true)
            {             
                age = "studentBirthDate > '" + CurrentTime.Day + "." + CurrentTime.Month + "." + (Convert.ToInt32(CurrentTime.Year) - numericUpDownAge.Value).ToString() + "'";
            }
            // Складывание фильтра
            filter = lastName;

            if (filter != "" & group != "")
                filter = filter + " and ";
            filter = filter + group;

            if (filter != "" & healthGroup != "")
                filter = filter + " and ";
            filter = filter + healthGroup;

            if (filter != "" & status != "")
                filter = filter + " and ";
            filter = filter + status;

            if (filter != "" & age != "")
                filter = filter + " and ";
            filter = filter + age;

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxLastName_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLastName.Enabled = checkBoxLastName.Checked;
        }

        private void checkBoxGroup_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGroup.Enabled = checkBoxGroup.Checked;
        }

        private void checkBoxHealthGroup_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxHealthGroup.Enabled = checkBoxHealthGroup.Checked;
        }

        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStatus.Enabled = checkBoxStatus.Checked;
        }

        private void checkBoxAge_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownAge.Enabled = checkBoxAge.Checked;
        }

        private void FormSearchStudentsForDisplay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_studentStatuses' table. You can move, or remove it, as needed.
            this.reference_studentStatusesTableAdapter.Fill(this.medofficeDataSet.reference_studentStatuses);
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_physicalEducationHealthGroups' table. You can move, or remove it, as needed.
            this.reference_physicalEducationHealthGroupsTableAdapter.Fill(this.medofficeDataSet.reference_physicalEducationHealthGroups);
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_Groups' table. You can move, or remove it, as needed.
            this.reference_GroupsTableAdapter.Fill(this.medofficeDataSet.reference_Groups);
        }
    }
}
