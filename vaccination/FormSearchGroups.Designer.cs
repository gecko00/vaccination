namespace vaccination
{
    partial class FormSearchGroups
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
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.checkBoxGraduationYear = new System.Windows.Forms.CheckBox();
            this.numericUpDownGraduationYear = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAdmissionYear = new System.Windows.Forms.CheckBox();
            this.numericUpDownAdmissionYear = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraduationYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdmissionYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.checkBoxGraduationYear);
            this.groupBoxFilters.Controls.Add(this.numericUpDownGraduationYear);
            this.groupBoxFilters.Controls.Add(this.checkBoxAdmissionYear);
            this.groupBoxFilters.Controls.Add(this.numericUpDownAdmissionYear);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(406, 67);
            this.groupBoxFilters.TabIndex = 41;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтры";
            // 
            // checkBoxGraduationYear
            // 
            this.checkBoxGraduationYear.AutoSize = true;
            this.checkBoxGraduationYear.Location = new System.Drawing.Point(262, 20);
            this.checkBoxGraduationYear.Name = "checkBoxGraduationYear";
            this.checkBoxGraduationYear.Size = new System.Drawing.Size(90, 17);
            this.checkBoxGraduationYear.TabIndex = 17;
            this.checkBoxGraduationYear.Text = "Год выпуска";
            this.checkBoxGraduationYear.UseVisualStyleBackColor = true;
            this.checkBoxGraduationYear.CheckedChanged += new System.EventHandler(this.checkBoxGraduationYear_CheckedChanged);
            // 
            // numericUpDownGraduationYear
            // 
            this.numericUpDownGraduationYear.Enabled = false;
            this.numericUpDownGraduationYear.Location = new System.Drawing.Point(262, 41);
            this.numericUpDownGraduationYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownGraduationYear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numericUpDownGraduationYear.Name = "numericUpDownGraduationYear";
            this.numericUpDownGraduationYear.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownGraduationYear.TabIndex = 16;
            this.numericUpDownGraduationYear.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // checkBoxAdmissionYear
            // 
            this.checkBoxAdmissionYear.AutoSize = true;
            this.checkBoxAdmissionYear.Location = new System.Drawing.Point(55, 20);
            this.checkBoxAdmissionYear.Name = "checkBoxAdmissionYear";
            this.checkBoxAdmissionYear.Size = new System.Drawing.Size(111, 17);
            this.checkBoxAdmissionYear.TabIndex = 0;
            this.checkBoxAdmissionYear.Text = "Год поступления";
            this.checkBoxAdmissionYear.UseVisualStyleBackColor = true;
            this.checkBoxAdmissionYear.CheckedChanged += new System.EventHandler(this.checkBoxAdmissionYear_CheckedChanged);
            // 
            // numericUpDownAdmissionYear
            // 
            this.numericUpDownAdmissionYear.Enabled = false;
            this.numericUpDownAdmissionYear.Location = new System.Drawing.Point(55, 41);
            this.numericUpDownAdmissionYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownAdmissionYear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numericUpDownAdmissionYear.Name = "numericUpDownAdmissionYear";
            this.numericUpDownAdmissionYear.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownAdmissionYear.TabIndex = 12;
            this.numericUpDownAdmissionYear.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::vaccination.Properties.Resources.decline;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(216, 85);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 27);
            this.buttonCancel.TabIndex = 43;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Image = global::vaccination.Properties.Resources.accept;
            this.buttonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccept.Location = new System.Drawing.Point(12, 85);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(200, 27);
            this.buttonAccept.TabIndex = 42;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // FormSearchGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 124);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.buttonAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSearchGroups";
            this.Text = "Поиск групп";
            this.Load += new System.EventHandler(this.FormSearchGroups_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraduationYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdmissionYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.CheckBox checkBoxAdmissionYear;
        private System.Windows.Forms.NumericUpDown numericUpDownAdmissionYear;
        private System.Windows.Forms.NumericUpDown numericUpDownGraduationYear;
        private System.Windows.Forms.CheckBox checkBoxGraduationYear;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
    }
}