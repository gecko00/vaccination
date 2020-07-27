namespace vaccination
{
    partial class FormSearchVaccination
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.textBoxControlNo = new System.Windows.Forms.TextBox();
            this.checkBoxControlNo = new System.Windows.Forms.CheckBox();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.checkBoxSerial = new System.Windows.Forms.CheckBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.referenceGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.checkBoxGroup = new System.Windows.Forms.CheckBox();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.checkBoxInCollege = new System.Windows.Forms.CheckBox();
            this.listBoxVaccineType = new System.Windows.Forms.ListBox();
            this.referencevaccineTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxVaccineType = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.reference_vaccineTypesTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_vaccineTypesTableAdapter();
            this.reference_GroupsTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_GroupsTableAdapter();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencevaccineTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.dateTimePickerDate);
            this.groupBoxFilters.Controls.Add(this.checkBoxDate);
            this.groupBoxFilters.Controls.Add(this.textBoxControlNo);
            this.groupBoxFilters.Controls.Add(this.checkBoxControlNo);
            this.groupBoxFilters.Controls.Add(this.textBoxSerial);
            this.groupBoxFilters.Controls.Add(this.checkBoxSerial);
            this.groupBoxFilters.Controls.Add(this.textBoxLastName);
            this.groupBoxFilters.Controls.Add(this.comboBoxGroups);
            this.groupBoxFilters.Controls.Add(this.checkBoxGroup);
            this.groupBoxFilters.Controls.Add(this.checkBoxLastName);
            this.groupBoxFilters.Controls.Add(this.radioButtonOut);
            this.groupBoxFilters.Controls.Add(this.radioButtonIn);
            this.groupBoxFilters.Controls.Add(this.checkBoxInCollege);
            this.groupBoxFilters.Controls.Add(this.listBoxVaccineType);
            this.groupBoxFilters.Controls.Add(this.checkBoxVaccineType);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(572, 134);
            this.groupBoxFilters.TabIndex = 42;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтры";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Location = new System.Drawing.Point(420, 103);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerDate.TabIndex = 18;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(420, 81);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDate.TabIndex = 17;
            this.checkBoxDate.Text = "Дата";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // textBoxControlNo
            // 
            this.textBoxControlNo.Enabled = false;
            this.textBoxControlNo.Location = new System.Drawing.Point(283, 103);
            this.textBoxControlNo.Name = "textBoxControlNo";
            this.textBoxControlNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxControlNo.TabIndex = 16;
            // 
            // checkBoxControlNo
            // 
            this.checkBoxControlNo.AutoSize = true;
            this.checkBoxControlNo.Location = new System.Drawing.Point(283, 81);
            this.checkBoxControlNo.Name = "checkBoxControlNo";
            this.checkBoxControlNo.Size = new System.Drawing.Size(129, 17);
            this.checkBoxControlNo.TabIndex = 15;
            this.checkBoxControlNo.Text = "Контрольный номер";
            this.checkBoxControlNo.UseVisualStyleBackColor = true;
            this.checkBoxControlNo.CheckedChanged += new System.EventHandler(this.checkBoxControlNo_CheckedChanged);
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Enabled = false;
            this.textBoxSerial.Location = new System.Drawing.Point(283, 41);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerial.TabIndex = 14;
            // 
            // checkBoxSerial
            // 
            this.checkBoxSerial.AutoSize = true;
            this.checkBoxSerial.Location = new System.Drawing.Point(283, 19);
            this.checkBoxSerial.Name = "checkBoxSerial";
            this.checkBoxSerial.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSerial.TabIndex = 13;
            this.checkBoxSerial.Text = "Серия";
            this.checkBoxSerial.UseVisualStyleBackColor = true;
            this.checkBoxSerial.CheckedChanged += new System.EventHandler(this.checkBoxSerial_CheckedChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(154, 41);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 12;
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DataSource = this.referenceGroupsBindingSource;
            this.comboBoxGroups.DisplayMember = "groupNo";
            this.comboBoxGroups.Enabled = false;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(154, 103);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGroups.TabIndex = 11;
            this.comboBoxGroups.ValueMember = "groupNo";
            // 
            // referenceGroupsBindingSource
            // 
            this.referenceGroupsBindingSource.DataMember = "reference_Groups";
            this.referenceGroupsBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.AutoSize = true;
            this.checkBoxGroup.Location = new System.Drawing.Point(154, 81);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGroup.TabIndex = 10;
            this.checkBoxGroup.Text = "Группа";
            this.checkBoxGroup.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Location = new System.Drawing.Point(154, 19);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(75, 17);
            this.checkBoxLastName.TabIndex = 8;
            this.checkBoxLastName.Text = "Фамилия";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            this.checkBoxLastName.CheckedChanged += new System.EventHandler(this.checkBoxLastName_CheckedChanged);
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.Enabled = false;
            this.radioButtonOut.Location = new System.Drawing.Point(420, 57);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(101, 17);
            this.radioButtonOut.TabIndex = 5;
            this.radioButtonOut.Text = "Не в колледже";
            this.radioButtonOut.UseVisualStyleBackColor = true;
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Checked = true;
            this.radioButtonIn.Enabled = false;
            this.radioButtonIn.Location = new System.Drawing.Point(420, 39);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(85, 17);
            this.radioButtonIn.TabIndex = 4;
            this.radioButtonIn.TabStop = true;
            this.radioButtonIn.Text = "В колледже";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            // 
            // checkBoxInCollege
            // 
            this.checkBoxInCollege.AutoSize = true;
            this.checkBoxInCollege.Location = new System.Drawing.Point(420, 19);
            this.checkBoxInCollege.Name = "checkBoxInCollege";
            this.checkBoxInCollege.Size = new System.Drawing.Size(121, 17);
            this.checkBoxInCollege.TabIndex = 3;
            this.checkBoxInCollege.Text = "Место проведения";
            this.checkBoxInCollege.UseVisualStyleBackColor = true;
            // 
            // listBoxVaccineType
            // 
            this.listBoxVaccineType.DataSource = this.referencevaccineTypesBindingSource;
            this.listBoxVaccineType.DisplayMember = "vaccineTypeName";
            this.listBoxVaccineType.Enabled = false;
            this.listBoxVaccineType.FormattingEnabled = true;
            this.listBoxVaccineType.Location = new System.Drawing.Point(6, 41);
            this.listBoxVaccineType.Name = "listBoxVaccineType";
            this.listBoxVaccineType.Size = new System.Drawing.Size(120, 82);
            this.listBoxVaccineType.TabIndex = 2;
            this.listBoxVaccineType.ValueMember = "vaccineTypeName";
            // 
            // referencevaccineTypesBindingSource
            // 
            this.referencevaccineTypesBindingSource.DataMember = "reference_vaccineTypes";
            this.referencevaccineTypesBindingSource.DataSource = this.medofficeDataSet;
            // 
            // checkBoxVaccineType
            // 
            this.checkBoxVaccineType.AutoSize = true;
            this.checkBoxVaccineType.Location = new System.Drawing.Point(6, 19);
            this.checkBoxVaccineType.Name = "checkBoxVaccineType";
            this.checkBoxVaccineType.Size = new System.Drawing.Size(92, 17);
            this.checkBoxVaccineType.TabIndex = 0;
            this.checkBoxVaccineType.Text = "Вид вакцины";
            this.checkBoxVaccineType.UseVisualStyleBackColor = true;
            this.checkBoxVaccineType.CheckedChanged += new System.EventHandler(this.checkBoxVaccineType_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::vaccination.Properties.Resources.decline;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(301, 152);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 27);
            this.buttonCancel.TabIndex = 44;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Image = global::vaccination.Properties.Resources.accept;
            this.buttonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccept.Location = new System.Drawing.Point(95, 152);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(200, 27);
            this.buttonAccept.TabIndex = 43;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // reference_vaccineTypesTableAdapter
            // 
            this.reference_vaccineTypesTableAdapter.ClearBeforeFill = true;
            // 
            // reference_GroupsTableAdapter
            // 
            this.reference_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // FormSearchVaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 190);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxFilters);
            this.Name = "FormSearchVaccination";
            this.Text = "Поиск записей о вакцинации";
            this.Load += new System.EventHandler(this.FormSearchVaccination_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencevaccineTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.ListBox listBoxVaccineType;
        private System.Windows.Forms.CheckBox checkBoxVaccineType;
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.BindingSource referencevaccineTypesBindingSource;
        private medofficeDataSetTableAdapters.reference_vaccineTypesTableAdapter reference_vaccineTypesTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonOut;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.CheckBox checkBoxInCollege;
        private System.Windows.Forms.BindingSource referenceGroupsBindingSource;
        private medofficeDataSetTableAdapters.reference_GroupsTableAdapter reference_GroupsTableAdapter;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.CheckBox checkBoxGroup;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.CheckBox checkBoxSerial;
        private System.Windows.Forms.TextBox textBoxControlNo;
        private System.Windows.Forms.CheckBox checkBoxControlNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.CheckBox checkBoxDate;
    }
}