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
    public partial class FormVaccination : Form
    {
        // Флаг редактирования. Если истина, то редактирование
        public bool editFlag;
        public bool deleteFlag;
        public object vaccinationKEY;
        

        public FormVaccination()
        {
            InitializeComponent();
        }



            private void FormVaccination_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.displayVaccinations' table. You can move, or remove it, as needed.
            this.displayVaccinationsTableAdapter.Fill(this.medofficeDataSet.displayVaccinations);

        }


        private void buttonRecordAdd_Click(object sender, EventArgs e)
        {
            editFlag = false;

            FormEditVaccination editingForm = new FormEditVaccination();
            editingForm.ShowDialog(this);

            this.displayVaccinationsTableAdapter.Fill(this.medofficeDataSet.displayVaccinations);

        }

        private void buttonRecordEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewVaccination.Rows.Count > 0) {
                editFlag = true;

                vaccinationKEY = dataGridViewVaccination.CurrentRow.Cells[0].Value.ToString();

                FormEditVaccination editingForm = new FormEditVaccination();
                editingForm.ShowDialog(this);

                this.displayVaccinationsTableAdapter.Fill(this.medofficeDataSet.displayVaccinations);
            }
        }

        private void buttonRecordDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы действительно хотите удалить запись о проведенной вакцинации?",
            "Удаление записи",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                deleteFlag = true;
                vaccinationKEY = dataGridViewVaccination.CurrentRow.Cells[0].Value.ToString();

                FormEditVaccination editingForm = new FormEditVaccination();
                editingForm.ShowDialog(this);

                this.displayVaccinationsTableAdapter.Fill(this.medofficeDataSet.displayVaccinations);
            }
        }

        private void buttonDataSetFilter_Click(object sender, EventArgs e)
        {
            FormSearchVaccination filterForm = new FormSearchVaccination();
            filterForm.ShowDialog();
            displayVaccinationsBindingSource.Filter = filterForm.filter;
        }
    }
}
