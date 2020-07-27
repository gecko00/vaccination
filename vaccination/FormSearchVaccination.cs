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
    public partial class FormSearchVaccination : Form
    {
        public string filter;

        string vaccineType = "";
        string lastName = "";
        string group = "";
        string serial = "";
        string controlNo = "";
        string date = "";
        string inCollege = "";

        public FormSearchVaccination()
        {
            InitializeComponent();
        }

        private void FormSearchVaccination_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_Groups' table. You can move, or remove it, as needed.
            this.reference_GroupsTableAdapter.Fill(this.medofficeDataSet.reference_Groups);
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_vaccineTypes' table. You can move, or remove it, as needed.
            this.reference_vaccineTypesTableAdapter.Fill(this.medofficeDataSet.reference_vaccineTypes);

        }

        private void checkBoxVaccineType_CheckedChanged(object sender, EventArgs e)
        {
            listBoxVaccineType.Enabled = checkBoxVaccineType.Checked;
        }

        private void checkBoxLastName_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLastName.Enabled = checkBoxLastName.Checked;
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = checkBoxDate.Checked;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkBoxSerial_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSerial.Enabled = checkBoxSerial.Enabled;
        }

        private void checkBoxControlNo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxControlNo.Enabled = checkBoxControlNo.Enabled;
        }


        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (checkBoxVaccineType.Checked == true)
            {
                vaccineType = "vaccineTypeName = '" + listBoxVaccineType.SelectedValue + "'";
            }

            if (checkBoxLastName.Checked == true)
            {
                lastName = "studentLastName = '" + textBoxLastName.Text + "'";
            }

            if (checkBoxGroup.Checked == true)
            {
                group = "groupNo = '" + comboBoxGroups.SelectedText + "'";
            }

            if (checkBoxSerial.Checked == true)
            {
                serial = "vaccineSerialNumber = '" + textBoxSerial.Text + "'";
            }

            if (checkBoxControlNo.Checked == true)
            {
                controlNo = "vaccineControlNumber = '" + textBoxControlNo.Text + "'";
            }

            if (checkBoxDate.Checked == true)
            {
                date = "vaccinationDate = '" + dateTimePickerDate.Value.ToShortDateString() + "'";
            }


            if (checkBoxInCollege.Checked == true)
            {
                if (radioButtonIn.Checked == true)
                    inCollege = "inCollege = '" + "true'";
                if (radioButtonOut.Checked == true)
                    inCollege = "inCollege = '" + "false'";
            }

            // Складывание фильтра
            filter = lastName;

            if (filter != "" & group != "")
                filter = filter + " and ";
            filter = filter + group;

            if (filter != "" & vaccineType != "")
                filter = filter + " and ";
            filter = filter + vaccineType;

            if (filter != "" & serial != "")
                filter = filter + " and ";
            filter = filter + serial;

            if (filter != "" & controlNo != "")
                filter = filter + " and ";
            filter = filter + controlNo;

            if (filter != "" & date != "")
                filter = filter + " and ";
            filter = filter + date;

            this.Close();
        }
    }
}
