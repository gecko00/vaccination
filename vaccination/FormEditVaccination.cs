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
    public partial class FormEditVaccination : Form
    {

        public FormEditVaccination()
        {
            InitializeComponent();
        }

        int key;

        private void FormEditVaccination_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_vaccineTypes' table. You can move, or remove it, as needed.
            this.reference_vaccineTypesTableAdapter.Fill(this.medofficeDataSet.reference_vaccineTypes);
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_Students' table. You can move, or remove it, as needed.
            this.reference_StudentsTableAdapter.Fill(this.medofficeDataSet.reference_Students);
            // TODO: This line of code loads data into the 'medofficeDataSet.operational_Vaccinations' table. You can move, or remove it, as needed.
            this.operational_VaccinationsTableAdapter.Fill(this.medofficeDataSet.operational_Vaccinations);

            fillStudentInfo();

            FormVaccination fv = (FormVaccination)this.Owner;
            key = Convert.ToInt32(fv.vaccinationKEY);
            dataGridViewVaccination.ClearSelection();
            foreach (DataGridViewRow gridRow in dataGridViewVaccination.Rows)
            {
                if (Convert.ToInt32(gridRow.Cells[0].Value) == key)
                {
                    gridRow.Selected = true;
                    dataGridViewVaccination.CurrentCell = gridRow.Cells[0];

                }
            }

            if (fv.deleteFlag == true)
            {
                // Удаление текущей строки
                this.operationalVaccinationsBindingSource.RemoveCurrent();
                // Завершение редактирования данных
                this.operationalVaccinationsBindingSource.EndEdit();
                // Обновление измененной базы данных
                this.operational_VaccinationsTableAdapter.Update(this.medofficeDataSet);

                this.Dispose();
                this.Close();
            }
            if (fv.editFlag == true)
            {
                this.Text = "Редактирование записи о проведенной вакцинации";

                comboBoxStudent.SelectedValue = dataGridViewVaccination.SelectedRows[0].Cells[1].Value;
                dateTimePickerDateV.Value = Convert.ToDateTime(dataGridViewVaccination.SelectedRows[0].Cells[2].Value);
                comboBoxVaccineType.SelectedValue = dataGridViewVaccination.SelectedRows[0].Cells[3].Value;
                textBoxSerial.Text = dataGridViewVaccination.SelectedRows[0].Cells[4].Value.ToString();
                textBoxControlNo.Text = dataGridViewVaccination.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePickerExpiration.Value = Convert.ToDateTime(dataGridViewVaccination.SelectedRows[0].Cells[6].Value);
                numericUpDownRepetition.Value = Convert.ToInt32(dataGridViewVaccination.SelectedRows[0].Cells[7].Value);
                checkBoxInCollege.Checked = Convert.ToBoolean(dataGridViewVaccination.SelectedRows[0].Cells[8].Value);
            }
        }

        void fillStudentInfo()
        {
            if (comboBoxStudent.SelectedValue != null)
            {
                labelLastName.Text = ((medofficeDataSet.reference_StudentsRow)((System.Data.DataRowView)referenceStudentsBindingSource.List[referenceStudentsBindingSource.Find("studentKEY", comboBoxStudent.SelectedValue)]).Row).studentLastName;
                labelFirstName.Text = ((medofficeDataSet.reference_StudentsRow)((System.Data.DataRowView)referenceStudentsBindingSource.List[referenceStudentsBindingSource.Find("studentKEY", comboBoxStudent.SelectedValue)]).Row).studentFirstName;
                labelPatronym.Text = ((medofficeDataSet.reference_StudentsRow)((System.Data.DataRowView)referenceStudentsBindingSource.List[referenceStudentsBindingSource.Find("studentKEY", comboBoxStudent.SelectedValue)]).Row).studentPatronym;
                labelBirthDate.Text = ((medofficeDataSet.reference_StudentsRow)((System.Data.DataRowView)referenceStudentsBindingSource.List[referenceStudentsBindingSource.Find("studentKEY", comboBoxStudent.SelectedValue)]).Row).studentBirthDate.ToShortDateString().ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearchStudents filterForm = new FormSearchStudents();
            filterForm.ShowDialog();
            referencevaccineTypesBindingSource.Filter = filterForm.filter;

            this.Close();
        }

       

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillStudentInfo();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {

            if (textBoxSerial.Text == "")
            {
                DialogResult alert;
                alert = MessageBox.Show("Не заполнена серия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (textBoxControlNo.Text == "")
            {
                DialogResult alert;
                alert = MessageBox.Show("Не заполнен контрольный номер!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            FormVaccination fv = (FormVaccination)this.Owner;
            if (fv.editFlag == true)
            {
                dataGridViewVaccination.ClearSelection();
                foreach (DataGridViewRow gridRow in dataGridViewVaccination.Rows)
                {
                    if (Convert.ToInt32(gridRow.Cells[0].Value) == key)
                    {
                        gridRow.Selected = true;
                        dataGridViewVaccination.CurrentCell = gridRow.Cells[0];
                        break;
                    }
                }

                dataGridViewVaccination.CurrentRow.SetValues(
                    dataGridViewVaccination.CurrentRow.Cells[0].Value,
                    comboBoxStudent.SelectedValue,
                    dateTimePickerDateV.Value,
                    comboBoxVaccineType.SelectedValue,
                    textBoxSerial.Text,
                    textBoxControlNo.Text,
                    dateTimePickerExpiration.Value,
                    numericUpDownRepetition.Value,
                    checkBoxInCollege.Checked
                );
            }
            else
            {
                operationalVaccinationsBindingSource.AddNew();

                dataGridViewVaccination.CurrentRow.SetValues(
                    dataGridViewVaccination.CurrentRow.Cells[0].Value,
                    comboBoxStudent.SelectedValue,
                    dateTimePickerDateV.Value,
                    comboBoxVaccineType.SelectedValue,
                    textBoxSerial.Text,
                    textBoxControlNo.Text,
                    dateTimePickerExpiration.Value,
                    numericUpDownRepetition.Value,
                    checkBoxInCollege.Checked
                );

            }
            this.operationalVaccinationsBindingSource.EndEdit();
            this.operational_VaccinationsTableAdapter.Update(this.medofficeDataSet);

            this.Close();
        }
    

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
