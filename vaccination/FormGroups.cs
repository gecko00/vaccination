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
    public partial class FormGroups : Form
    {
        // Флаг редактирования. Если истина, то редактирование
        bool editFlag;

        // Текущая дата
        DateTime CurrentTime = DateTime.Now;

        // Начать редактирование элементов
        void reduceVisibility()
        {
            buttonAccept.Visible = true;
            buttonCancel.Visible = true;
            groupBoxEducationClasses.Enabled = true;
            groupBoxYears.Enabled = true;
            groupBoxTutor.Enabled = true;
            maskedTextBoxGroupNo.Enabled = true;
            panelMenu.Enabled = false;
            dataGridViewGroups.Enabled = false;
        }

        // Окончить редактирование элементов
        void restoreVisibility()
        {
            buttonAccept.Visible = false;
            buttonCancel.Visible = false;
            groupBoxEducationClasses.Enabled = false;
            groupBoxYears.Enabled = false;
            groupBoxTutor.Enabled = false;
            maskedTextBoxGroupNo.Enabled = false;
            panelMenu.Enabled = true;
            dataGridViewGroups.Enabled = true;
        }

        // Заполнить элементы из dataGridView
        void refreshControls()
        {            
            if(dataGridViewGroups.Rows.Count != 1)
            {
                // Год поступления
                numericUpDownFrom.Value = Convert.ToInt32(dataGridViewGroups.CurrentRow.Cells[2].Value);

                // Номер группы
                if (dataGridViewGroups.CurrentRow.Cells[1].Value.ToString().Length == 3)
                {
                    radioButton9.Checked = true;
                    labelTo.Text = "по   " + (numericUpDownFrom.Value + 4).ToString();

                }
                else
                {
                    radioButton11.Checked = true;
                    labelTo.Text = "по   " + (numericUpDownFrom.Value + 3).ToString();
                }
                maskedTextBoxGroupNo.Text = dataGridViewGroups.CurrentRow.Cells[1].Value.ToString();

                // Преподаватель
                textBoxTutor.Text = dataGridViewGroups.CurrentRow.Cells[4].Value.ToString();
                maskedTextBoxClassroom.Text = dataGridViewGroups.CurrentRow.Cells[5].Value.ToString();
            }
        }

        // Заполняет доступные года обучения
        void setAvailableYears()
        {
            numericUpDownFrom.Minimum = 2010;
            numericUpDownFrom.Maximum = CurrentTime.Year;

            if (radioButton11.Checked == true)
            {
                labelTo.Text = "по   " + (numericUpDownFrom.Value + 4).ToString();
            }
            else
            {
                labelTo.Text = "по   " + (numericUpDownFrom.Value + 3).ToString();
            }
        }

            public FormGroups()
        {
            InitializeComponent();
        }

        private void buttonDataSetFilter_Click(object sender, EventArgs e)
        {
            FormSearchGroups filterForm = new FormSearchGroups();
            filterForm.ShowDialog();
            referenceGroupsBindingSource.Filter = filterForm.filter;
        }

        private void FormGroups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_Groups' table. You can move, or remove it, as needed.
            this.reference_GroupsTableAdapter.Fill(this.medofficeDataSet.reference_Groups);

            setAvailableYears();
            refreshControls();
        }

        private void buttonRecordAdd_Click(object sender, EventArgs e)
        {
            reduceVisibility();
            editFlag = false;

            referenceGroupsBindingSource.AddNew();
        }

        private void buttonRecordEdit_Click(object sender, EventArgs e)
        {
            reduceVisibility();
            editFlag = true;
        }

        private void buttonRecordDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы действительно хотите удалить запись о группе?",
            "Удаление записи",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                // Удаление текущей строки
                this.referenceGroupsBindingSource.RemoveCurrent();
                // Завершение редактирования данных
                this.referenceGroupsBindingSource.EndEdit();
                // Обновление измененной базы данных
                this.reference_GroupsTableAdapter.Update(this.medofficeDataSet);
            }
        }
        
        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshControls();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы хотите сохранить изменения?",
            "Сохранение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                if (radioButton11.Checked == true) { 
                    dataGridViewGroups.CurrentRow.SetValues(
                        dataGridViewGroups.CurrentRow.Cells[0].Value,
                        maskedTextBoxGroupNo.Text,
                        numericUpDownFrom.Value,
                        numericUpDownFrom.Value + 3,
                        textBoxTutor.Text,
                        maskedTextBoxClassroom.Text
                    );
                }
                else
                {
                    dataGridViewGroups.CurrentRow.SetValues(
                        dataGridViewGroups.CurrentRow.Cells[0].Value,
                        maskedTextBoxGroupNo.Text,
                        numericUpDownFrom.Value,
                        numericUpDownFrom.Value + 4,
                        textBoxTutor.Text,
                        maskedTextBoxClassroom.Text
                    );
                }

                this.referenceGroupsBindingSource.EndEdit();
                this.reference_GroupsTableAdapter.Update(this.medofficeDataSet);
                restoreVisibility();
                dataGridViewGroups.Enabled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (editFlag == false)
            {
                dataGridViewGroups.Rows.Remove(dataGridViewGroups.CurrentRow);
            }

            refreshControls();
            restoreVisibility();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                maskedTextBoxGroupNo.Mask = "00";
                labelTo.Text = "по   " + (numericUpDownFrom.Value + 4).ToString();
            }
            else
            {
                maskedTextBoxGroupNo.Mask = "000";
                labelTo.Text = "по   " + (numericUpDownFrom.Value + 3).ToString();
            }
        }

        private void numericUpDownFrom_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                labelTo.Text = "по   " + (numericUpDownFrom.Value + 4).ToString();
            }
            else
            {
                labelTo.Text = "по   " + (numericUpDownFrom.Value + 3).ToString();
            }
        }
    }
}
