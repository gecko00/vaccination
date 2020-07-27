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
    public partial class FormQueryVaccinationToDo : Form
    {
        public FormQueryVaccinationToDo()
        {
            InitializeComponent();
        }

        private void FormQueryVaccinationToDo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medofficeDataSet.reference_vaccineTypes' table. You can move, or remove it, as needed.
            this.reference_vaccineTypesTableAdapter.Fill(this.medofficeDataSet.reference_vaccineTypes);

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            query_VaccinationToDoTableAdapter.Fill(medofficeDataSet.query_VaccinationToDo, dateTimePickerStart.Value, dateTimePickerEnd.Value, Convert.ToInt32(listBox1.SelectedValue.ToString()));
        }
    }
}
