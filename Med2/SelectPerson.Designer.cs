namespace Med2
{
    partial class SelectPerson
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxBirth = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSelectPerson = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDocs = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxPat = new System.Windows.Forms.CheckBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxBirth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(329, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // checkBoxBirth
            // 
            this.checkBoxBirth.AutoSize = true;
            this.checkBoxBirth.Location = new System.Drawing.Point(184, 98);
            this.checkBoxBirth.Name = "checkBoxBirth";
            this.checkBoxBirth.Size = new System.Drawing.Size(157, 17);
            this.checkBoxBirth.TabIndex = 6;
            this.checkBoxBirth.Text = "Искать по дате рождения";
            this.checkBoxBirth.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSelectPerson
            // 
            this.buttonSelectPerson.Location = new System.Drawing.Point(12, 167);
            this.buttonSelectPerson.Name = "buttonSelectPerson";
            this.buttonSelectPerson.Size = new System.Drawing.Size(209, 23);
            this.buttonSelectPerson.TabIndex = 8;
            this.buttonSelectPerson.Text = "Изменить данные";
            this.buttonSelectPerson.UseVisualStyleBackColor = true;
            this.buttonSelectPerson.Click += new System.EventHandler(this.buttonSelectPerson_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // checkBoxDocs
            // 
            this.checkBoxDocs.AutoSize = true;
            this.checkBoxDocs.Location = new System.Drawing.Point(184, 121);
            this.checkBoxDocs.Name = "checkBoxDocs";
            this.checkBoxDocs.Size = new System.Drawing.Size(139, 17);
            this.checkBoxDocs.TabIndex = 12;
            this.checkBoxDocs.Text = "Искать только врачей";
            this.checkBoxDocs.UseVisualStyleBackColor = true;
            this.checkBoxDocs.CheckedChanged += new System.EventHandler(this.checkBoxDocs_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(184, 75);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(113, 17);
            this.checkBoxName.TabIndex = 13;
            this.checkBoxName.Text = "Искать по имени";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxPat
            // 
            this.checkBoxPat.AutoSize = true;
            this.checkBoxPat.Location = new System.Drawing.Point(184, 144);
            this.checkBoxPat.Name = "checkBoxPat";
            this.checkBoxPat.Size = new System.Drawing.Size(157, 17);
            this.checkBoxPat.TabIndex = 14;
            this.checkBoxPat.Text = "Искать только пациентов";
            this.checkBoxPat.UseVisualStyleBackColor = true;
            this.checkBoxPat.CheckedChanged += new System.EventHandler(this.checkBoxPat_CheckedChanged);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 71);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(165, 23);
            this.buttonFind.TabIndex = 15;
            this.buttonFind.Text = "Найти людей";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(228, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(113, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxBirth
            // 
            this.comboBoxBirth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBirth.FormattingEnabled = true;
            this.comboBoxBirth.Items.AddRange(new object[] {
            "Раньше чем",
            "Раньше чем и в эту дату",
            "Ровно",
            "Позже чем и в эту дату",
            "Позже чем"});
            this.comboBoxBirth.Location = new System.Drawing.Point(12, 38);
            this.comboBoxBirth.Name = "comboBoxBirth";
            this.comboBoxBirth.Size = new System.Drawing.Size(144, 21);
            this.comboBoxBirth.TabIndex = 17;
            // 
            // SelectPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 230);
            this.Controls.Add(this.comboBoxBirth);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.checkBoxPat);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxDocs);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSelectPerson);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxBirth);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectPerson";
            this.Text = "Поиск человека";
            this.Load += new System.EventHandler(this.SelectPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxBirth;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSelectPerson;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxDocs;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxPat;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxBirth;
    }
}