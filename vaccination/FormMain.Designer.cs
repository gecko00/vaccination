namespace vaccination
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonVaccineTypes = new System.Windows.Forms.Button();
            this.groupBoxPrimaryReferences = new System.Windows.Forms.GroupBox();
            this.buttonVaccination = new System.Windows.Forms.Button();
            this.buttonQueryVaccinationToDo = new System.Windows.Forms.Button();
            this.groupBoxPrimaryReferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(6, 19);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(180, 34);
            this.buttonStudents.TabIndex = 0;
            this.buttonStudents.Text = "Студенты";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Location = new System.Drawing.Point(6, 59);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(180, 34);
            this.buttonGroups.TabIndex = 1;
            this.buttonGroups.Text = "Группы";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonVaccineTypes
            // 
            this.buttonVaccineTypes.Location = new System.Drawing.Point(6, 99);
            this.buttonVaccineTypes.Name = "buttonVaccineTypes";
            this.buttonVaccineTypes.Size = new System.Drawing.Size(180, 34);
            this.buttonVaccineTypes.TabIndex = 2;
            this.buttonVaccineTypes.Text = "Виды прививок";
            this.buttonVaccineTypes.UseVisualStyleBackColor = true;
            this.buttonVaccineTypes.Click += new System.EventHandler(this.buttonVaccineTypes_Click);
            // 
            // groupBoxPrimaryReferences
            // 
            this.groupBoxPrimaryReferences.Controls.Add(this.buttonGroups);
            this.groupBoxPrimaryReferences.Controls.Add(this.buttonVaccineTypes);
            this.groupBoxPrimaryReferences.Controls.Add(this.buttonStudents);
            this.groupBoxPrimaryReferences.Location = new System.Drawing.Point(488, 12);
            this.groupBoxPrimaryReferences.Name = "groupBoxPrimaryReferences";
            this.groupBoxPrimaryReferences.Size = new System.Drawing.Size(200, 138);
            this.groupBoxPrimaryReferences.TabIndex = 3;
            this.groupBoxPrimaryReferences.TabStop = false;
            this.groupBoxPrimaryReferences.Text = "Справочники";
            // 
            // buttonVaccination
            // 
            this.buttonVaccination.Location = new System.Drawing.Point(12, 17);
            this.buttonVaccination.Name = "buttonVaccination";
            this.buttonVaccination.Size = new System.Drawing.Size(470, 88);
            this.buttonVaccination.TabIndex = 5;
            this.buttonVaccination.Text = "Прививки";
            this.buttonVaccination.UseVisualStyleBackColor = true;
            this.buttonVaccination.Click += new System.EventHandler(this.buttonVaccination_Click);
            // 
            // buttonQueryVaccinationToDo
            // 
            this.buttonQueryVaccinationToDo.Location = new System.Drawing.Point(12, 111);
            this.buttonQueryVaccinationToDo.Name = "buttonQueryVaccinationToDo";
            this.buttonQueryVaccinationToDo.Size = new System.Drawing.Size(470, 33);
            this.buttonQueryVaccinationToDo.TabIndex = 6;
            this.buttonQueryVaccinationToDo.Text = "Найти студентов, не прошедших вакцинацию";
            this.buttonQueryVaccinationToDo.UseVisualStyleBackColor = true;
            this.buttonQueryVaccinationToDo.Click += new System.EventHandler(this.buttonQueryVaccinationToDo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 154);
            this.Controls.Add(this.buttonQueryVaccinationToDo);
            this.Controls.Add(this.buttonVaccination);
            this.Controls.Add(this.groupBoxPrimaryReferences);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Прививки СПбКИТ";
            this.groupBoxPrimaryReferences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonVaccineTypes;
        private System.Windows.Forms.GroupBox groupBoxPrimaryReferences;
        private System.Windows.Forms.Button buttonVaccination;
        private System.Windows.Forms.Button buttonQueryVaccinationToDo;
    }
}

