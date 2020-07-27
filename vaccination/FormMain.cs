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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            FormStudents fs = new FormStudents();
            fs.ShowDialog();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            FormGroups fg = new FormGroups();
            fg.ShowDialog();
        }

        private void buttonVaccination_Click(object sender, EventArgs e)
        {
            {
                FormVaccination fv = new FormVaccination();
                fv.ShowDialog();
            }
        }

        private void buttonVaccineTypes_Click(object sender, EventArgs e)
        {
            FormVaccineTypes fvt = new FormVaccineTypes();
            fvt.ShowDialog();
        }

        private void buttonQueryVaccinationToDo_Click(object sender, EventArgs e)
        {
            FormQueryVaccinationToDo fqv = new FormQueryVaccinationToDo();
            fqv.ShowDialog();
        }
    }
}
