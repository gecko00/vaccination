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
    public partial class FormVaccineTypes : Form
    {
        // Флаг редактирования. Если истина, то редактирование
        bool editFlag;

        // Начать редактирование элементов
        void reduceVisibility()
        {
            buttonAccept.Visible = true;
            buttonCancel.Visible = true;
            textBoxVaccineTypeName.Enabled = true;

            panelMenu.Enabled = false;
            dataGridViewVaccineTypes.Enabled = false;
        }

        // Окончить редактирование элементов
        void restoreVisibility()
        {
            buttonAccept.Visible = false;
            buttonCancel.Visible = false;
            textBoxVaccineTypeName.Enabled = false;

            panelMenu.Enabled = true;
            dataGridViewVaccineTypes.Enabled = true;
        }

        // Заполнить элементы из dataGridView
        void refreshControls()
        {
            if (dataGridViewVaccineTypes.Rows.Count != 0)
            {
                textBoxVaccineTypeName.Text = dataGridViewVaccineTypes.CurrentRow.Cells[1].Value.ToString();
            }
        }

                public FormVaccineTypes()
        {
            InitializeComponent();
        }

        private void FormVaccineTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_vaccineTypes' table. You can move, or remove it, as needed.
            this.reference_vaccineTypesTableAdapter.Fill(this.medofficeDataSet.reference_vaccineTypes);

            refreshControls();
        }

        private void buttonRecordAdd_Click(object sender, EventArgs e)
        {
            reduceVisibility();
            editFlag = false;

            referencevaccineTypesBindingSource.AddNew();
        }

        private void buttonRecordEdit_Click(object sender, EventArgs e)
        {
            reduceVisibility();
            editFlag = true;
        }

        private void buttonRecordDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        "Удаление записи",
                        "Вы действительно хотите удалить запись о типе вакцины?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                // Удаление текущей строки
                this.referencevaccineTypesBindingSource.RemoveCurrent();
                // Завершение редактирования данных
                this.referencevaccineTypesBindingSource.EndEdit();
                // Обновление измененной базы данных
                this.reference_vaccineTypesTableAdapter.Update(this.medofficeDataSet);
            }
        }

        private void buttonDataSetFilter_Click(object sender, EventArgs e)
        {

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
                dataGridViewVaccineTypes.CurrentRow.SetValues(
                    dataGridViewVaccineTypes.CurrentRow.Cells[0].Value,
                    textBoxVaccineTypeName.Text
                );

                this.referencevaccineTypesBindingSource.EndEdit();
                this.reference_vaccineTypesTableAdapter.Update(this.medofficeDataSet);
                restoreVisibility();
                dataGridViewVaccineTypes.Enabled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (editFlag == false)
            {
                dataGridViewVaccineTypes.Rows.Remove(dataGridViewVaccineTypes.CurrentRow);
            }

            refreshControls();
            restoreVisibility();
        }
    }
}
