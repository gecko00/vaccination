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
    public partial class FormEditStudents : Form
    {

        public FormEditStudents()
        {
            InitializeComponent();
        }

        int key;

        private void FormEditStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_Students' table. You can move, or remove it, as needed.
            this.reference_StudentsTableAdapter.Fill(this.medofficeDataSet.reference_Students);
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_Groups' table. You can move, or remove it, as needed.
            this.reference_GroupsTableAdapter.Fill(this.medofficeDataSet.reference_Groups);
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_studentStatuses' table. You can move, or remove it, as needed.
            this.reference_studentStatusesTableAdapter.Fill(this.medofficeDataSet.reference_studentStatuses);
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_physicalEducationHealthGroups' table. You can move, or remove it, as needed.
            this.reference_physicalEducationHealthGroupsTableAdapter.Fill(this.medofficeDataSet.reference_physicalEducationHealthGroups);

            FormStudents fs = (FormStudents)this.Owner;
            key = Convert.ToInt32(fs.studentKEY);
            dataGridViewStudents.ClearSelection();
            foreach (DataGridViewRow gridRow in dataGridViewStudents.Rows)
            {
                if (Convert.ToInt32(gridRow.Cells[0].Value) == key)
                {
                    gridRow.Selected = true;
                    dataGridViewStudents.CurrentCell = gridRow.Cells[0];

                }
            }

            if (fs.deleteFlag == true)
            {                
                // Удаление текущей строки
                this.referenceStudentsBindingSource.RemoveCurrent();
                // Завершение редактирования данных
                this.referenceStudentsBindingSource.EndEdit();
                // Обновление измененной базы данных
                this.reference_StudentsTableAdapter.Update(this.medofficeDataSet);

                this.Dispose();
                this.Close();
            }


            if (fs.editFlag == true)
            {
                this.Text = "Редактирование записи о студенте";

                textBoxLastName.Text = dataGridViewStudents.SelectedRows[0].Cells[1].Value.ToString();
                textBoxFirstName.Text = dataGridViewStudents.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPatronym.Text = dataGridViewStudents.SelectedRows[0].Cells[3].Value.ToString();

                dateTimePickerBirthDate.Value = Convert.ToDateTime(dataGridViewStudents.SelectedRows[0].Cells[4].Value);

                textBoxAddress.Text = dataGridViewStudents.SelectedRows[0].Cells[5].Value.ToString();
                textBoxSchool.Text = dataGridViewStudents.SelectedRows[0].Cells[6].Value.ToString();
                textBoxPElimitations.Text = dataGridViewStudents.SelectedRows[0].Cells[10].Value.ToString();

                comboBoxGroup.SelectedValue = dataGridViewStudents.SelectedRows[0].Cells[7].Value;
                comboBoxStatus.SelectedValue = dataGridViewStudents.SelectedRows[0].Cells[8].Value;
                comboBoxPEgroup.SelectedValue = dataGridViewStudents.SelectedRows[0].Cells[9].Value;
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "")
            {
                DialogResult alert;
                alert = MessageBox.Show("Не заполнена фамилия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (textBoxFirstName.Text == "")
            {
                DialogResult alert;
                alert = MessageBox.Show("Не заполнено имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (textBoxPatronym.Text == "")
            {
                DialogResult alert;
                alert = MessageBox.Show("Не заполнено отчество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormStudents fs = (FormStudents)this.Owner;
            if (fs.editFlag == true)
            {
                dataGridViewStudents.ClearSelection();
                foreach (DataGridViewRow gridRow in dataGridViewStudents.Rows)
                {
                    if (Convert.ToInt32(gridRow.Cells[0].Value) == key)
                    {
                        gridRow.Selected = true;
                        dataGridViewStudents.CurrentCell = gridRow.Cells[0];
                        break;
                    }
                }
               
                dataGridViewStudents.CurrentRow.SetValues(
                    dataGridViewStudents.CurrentRow.Cells[0].Value,
                    textBoxLastName.Text,
                    textBoxFirstName.Text,
                    textBoxPatronym.Text,
                    dateTimePickerBirthDate.Value,
                    textBoxAddress.Text,
                    textBoxSchool.Text,
                    comboBoxGroup.SelectedValue,
                    comboBoxStatus.SelectedValue,
                    comboBoxPEgroup.SelectedValue,
                    textBoxPElimitations.Text
                );
            }
            else
            {
                referenceStudentsBindingSource.AddNew();

                dataGridViewStudents.CurrentRow.SetValues(
                    dataGridViewStudents.CurrentRow.Cells[0].Value,
                    textBoxLastName.Text,
                    textBoxFirstName.Text,
                    textBoxPatronym.Text,
                    dateTimePickerBirthDate.Value,
                    textBoxAddress.Text,
                    textBoxSchool.Text,
                    comboBoxGroup.SelectedValue,
                    comboBoxStatus.SelectedValue,
                    comboBoxPEgroup.SelectedValue,
                    textBoxPElimitations.Text
                );
            }

            this.referenceStudentsBindingSource.EndEdit();
            this.reference_StudentsTableAdapter.Update(this.medofficeDataSet);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
