namespace vaccination
{
    partial class FormVaccineTypes
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
            this.dataGridViewVaccineTypes = new System.Windows.Forms.DataGridView();
            this.vaccineTypeKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencevaccineTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medofficeDataSet = new vaccination.medofficeDataSet();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxVaccineTypeName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.reference_vaccineTypesTableAdapter = new vaccination.medofficeDataSetTableAdapters.reference_vaccineTypesTableAdapter();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonRecordDelete = new System.Windows.Forms.Button();
            this.buttonRecordEdit = new System.Windows.Forms.Button();
            this.buttonRecordAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccineTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencevaccineTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVaccineTypes
            // 
            this.dataGridViewVaccineTypes.AllowUserToAddRows = false;
            this.dataGridViewVaccineTypes.AllowUserToDeleteRows = false;
            this.dataGridViewVaccineTypes.AutoGenerateColumns = false;
            this.dataGridViewVaccineTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccineTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccineTypeKEYDataGridViewTextBoxColumn,
            this.vaccineTypeNameDataGridViewTextBoxColumn});
            this.dataGridViewVaccineTypes.DataSource = this.referencevaccineTypesBindingSource;
            this.dataGridViewVaccineTypes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVaccineTypes.Name = "dataGridViewVaccineTypes";
            this.dataGridViewVaccineTypes.ReadOnly = true;
            this.dataGridViewVaccineTypes.Size = new System.Drawing.Size(533, 285);
            this.dataGridViewVaccineTypes.TabIndex = 2;
            // 
            // vaccineTypeKEYDataGridViewTextBoxColumn
            // 
            this.vaccineTypeKEYDataGridViewTextBoxColumn.DataPropertyName = "vaccineTypeKEY";
            this.vaccineTypeKEYDataGridViewTextBoxColumn.HeaderText = "Код";
            this.vaccineTypeKEYDataGridViewTextBoxColumn.Name = "vaccineTypeKEYDataGridViewTextBoxColumn";
            this.vaccineTypeKEYDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccineTypeKEYDataGridViewTextBoxColumn.Width = 70;
            // 
            // vaccineTypeNameDataGridViewTextBoxColumn
            // 
            this.vaccineTypeNameDataGridViewTextBoxColumn.DataPropertyName = "vaccineTypeName";
            this.vaccineTypeNameDataGridViewTextBoxColumn.HeaderText = "Наименование вакцины";
            this.vaccineTypeNameDataGridViewTextBoxColumn.Name = "vaccineTypeNameDataGridViewTextBoxColumn";
            this.vaccineTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccineTypeNameDataGridViewTextBoxColumn.Width = 400;
            // 
            // referencevaccineTypesBindingSource
            // 
            this.referencevaccineTypesBindingSource.DataMember = "reference_vaccineTypes";
            this.referencevaccineTypesBindingSource.DataSource = this.medofficeDataSet;
            // 
            // medofficeDataSet
            // 
            this.medofficeDataSet.DataSetName = "medofficeDataSet";
            this.medofficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 361);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(133, 13);
            this.labelLastName.TabIndex = 13;
            this.labelLastName.Text = "Наименование вакцины:";
            // 
            // textBoxVaccineTypeName
            // 
            this.textBoxVaccineTypeName.Enabled = false;
            this.textBoxVaccineTypeName.Location = new System.Drawing.Point(151, 358);
            this.textBoxVaccineTypeName.Name = "textBoxVaccineTypeName";
            this.textBoxVaccineTypeName.Size = new System.Drawing.Size(220, 20);
            this.textBoxVaccineTypeName.TabIndex = 12;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::vaccination.Properties.Resources.decline;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(392, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 38);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Image = global::vaccination.Properties.Resources.accept;
            this.buttonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccept.Location = new System.Drawing.Point(392, 348);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(153, 38);
            this.buttonAccept.TabIndex = 31;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Visible = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // reference_vaccineTypesTableAdapter
            // 
            this.reference_vaccineTypesTableAdapter.ClearBeforeFill = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonRecordDelete);
            this.panelMenu.Controls.Add(this.buttonRecordEdit);
            this.panelMenu.Controls.Add(this.buttonRecordAdd);
            this.panelMenu.Location = new System.Drawing.Point(12, 303);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(533, 41);
            this.panelMenu.TabIndex = 33;
            // 
            // buttonRecordDelete
            // 
            this.buttonRecordDelete.Image = global::vaccination.Properties.Resources.delete;
            this.buttonRecordDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordDelete.Location = new System.Drawing.Point(342, 4);
            this.buttonRecordDelete.Name = "buttonRecordDelete";
            this.buttonRecordDelete.Size = new System.Drawing.Size(139, 33);
            this.buttonRecordDelete.TabIndex = 15;
            this.buttonRecordDelete.Text = "Удалить";
            this.buttonRecordDelete.UseVisualStyleBackColor = true;
            this.buttonRecordDelete.Click += new System.EventHandler(this.buttonRecordDelete_Click);
            // 
            // buttonRecordEdit
            // 
            this.buttonRecordEdit.Image = global::vaccination.Properties.Resources.edit;
            this.buttonRecordEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordEdit.Location = new System.Drawing.Point(197, 4);
            this.buttonRecordEdit.Name = "buttonRecordEdit";
            this.buttonRecordEdit.Size = new System.Drawing.Size(139, 33);
            this.buttonRecordEdit.TabIndex = 13;
            this.buttonRecordEdit.Text = "Редактировать";
            this.buttonRecordEdit.UseVisualStyleBackColor = true;
            this.buttonRecordEdit.Click += new System.EventHandler(this.buttonRecordEdit_Click);
            // 
            // buttonRecordAdd
            // 
            this.buttonRecordAdd.Image = global::vaccination.Properties.Resources.add;
            this.buttonRecordAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecordAdd.Location = new System.Drawing.Point(52, 4);
            this.buttonRecordAdd.Name = "buttonRecordAdd";
            this.buttonRecordAdd.Size = new System.Drawing.Size(139, 33);
            this.buttonRecordAdd.TabIndex = 12;
            this.buttonRecordAdd.Text = "Добавить";
            this.buttonRecordAdd.UseVisualStyleBackColor = true;
            this.buttonRecordAdd.Click += new System.EventHandler(this.buttonRecordAdd_Click);
            // 
            // FormVaccineTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 442);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxVaccineTypeName);
            this.Controls.Add(this.dataGridViewVaccineTypes);
            this.Name = "FormVaccineTypes";
            this.Text = "Справочник: виды вакцин";
            this.Load += new System.EventHandler(this.FormVaccineTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccineTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencevaccineTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medofficeDataSet)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVaccineTypes;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxVaccineTypeName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private medofficeDataSet medofficeDataSet;
        private System.Windows.Forms.BindingSource referencevaccineTypesBindingSource;
        private medofficeDataSetTableAdapters.reference_vaccineTypesTableAdapter reference_vaccineTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineTypeKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonRecordDelete;
        private System.Windows.Forms.Button buttonRecordEdit;
        private System.Windows.Forms.Button buttonRecordAdd;
    }
}