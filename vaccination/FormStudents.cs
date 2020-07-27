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
    public partial class FormStudents : Form
    {
        // Флаг редактирования. Если истина, то редактирование
        public bool editFlag;
        public bool deleteFlag;
        public object studentKEY;

        public FormStudents()
        {
            InitializeComponent();
        }

        void fillControls()
        {
            if (dataGridViewStudents.Rows.Count > 0)
            {
                textBoxPElimitations.Text = dataGridViewStudents.CurrentRow.Cells[8].Value.ToString();
                textBoxSchool.Text = dataGridViewStudents.CurrentRow.Cells[9].Value.ToString();
                textBoxAddress.Text = dataGridViewStudents.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void buttonRecordAdd_Click(object sender, EventArgs e)
        {
            editFlag = false;

            FormEditStudents editingForm = new FormEditStudents();
            editingForm.ShowDialog(this);

            this.displayStudentsTableAdapter.Fill(this.medofficeDataSet.displayStudents);
        }

        private void buttonRecordEdit_Click(object sender, EventArgs e)
        {
            editFlag = true;

            studentKEY = dataGridViewStudents.CurrentRow.Cells[0].Value.ToString();

            FormEditStudents editingForm = new FormEditStudents();
            editingForm.ShowDialog(this);

            this.displayStudentsTableAdapter.Fill(this.medofficeDataSet.displayStudents);
        }

        private void buttonRecordDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы действительно хотите удалить запись о студенте?",
            "Удаление записи",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                deleteFlag = true;
                studentKEY = dataGridViewStudents.CurrentRow.Cells[0].Value.ToString();

                FormEditStudents editingForm = new FormEditStudents();
                editingForm.ShowDialog(this);

                this.displayStudentsTableAdapter.Fill(this.medofficeDataSet.displayStudents);
            }
        }

        private void buttonDataSetFilter_Click(object sender, EventArgs e)
        {
            FormSearchStudentsForDisplay filterForm = new FormSearchStudentsForDisplay();
            filterForm.ShowDialog();
            displayStudentsBindingSource.Filter = filterForm.filter;
            fillControls();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.displayStudents' table. You can move, or remove it, as needed.
            this.displayStudentsTableAdapter.Fill(this.medofficeDataSet.displayStudents);

            fillControls();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillControls();
        }
    }
}
