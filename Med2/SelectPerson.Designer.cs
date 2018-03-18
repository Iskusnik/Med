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
            this.checkBoxIsDoctor = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSelectPerson = new System.Windows.Forms.Button();
            this.buttonName = new System.Windows.Forms.Button();
            this.buttonBirth = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(221, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // checkBoxIsDoctor
            // 
            this.checkBoxIsDoctor.AutoSize = true;
            this.checkBoxIsDoctor.Location = new System.Drawing.Point(291, 75);
            this.checkBoxIsDoctor.Name = "checkBoxIsDoctor";
            this.checkBoxIsDoctor.Size = new System.Drawing.Size(50, 17);
            this.checkBoxIsDoctor.TabIndex = 6;
            this.checkBoxIsDoctor.Text = "Врач";
            this.checkBoxIsDoctor.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // buttonSelectPerson
            // 
            this.buttonSelectPerson.Location = new System.Drawing.Point(13, 102);
            this.buttonSelectPerson.Name = "buttonSelectPerson";
            this.buttonSelectPerson.Size = new System.Drawing.Size(144, 23);
            this.buttonSelectPerson.TabIndex = 8;
            this.buttonSelectPerson.Text = "Выбрать человека";
            this.buttonSelectPerson.UseVisualStyleBackColor = true;
            // 
            // buttonName
            // 
            this.buttonName.Location = new System.Drawing.Point(12, 12);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(101, 23);
            this.buttonName.TabIndex = 9;
            this.buttonName.Text = "Выбрать имя";
            this.buttonName.UseVisualStyleBackColor = true;
            // 
            // buttonBirth
            // 
            this.buttonBirth.Location = new System.Drawing.Point(13, 47);
            this.buttonBirth.Name = "buttonBirth";
            this.buttonBirth.Size = new System.Drawing.Size(101, 23);
            this.buttonBirth.TabIndex = 10;
            this.buttonBirth.Text = "Выбрать д.р.";
            this.buttonBirth.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // SelectPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 166);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonBirth);
            this.Controls.Add(this.buttonName);
            this.Controls.Add(this.buttonSelectPerson);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxIsDoctor);
            this.Controls.Add(this.textBoxName);
            this.Name = "SelectPerson";
            this.Text = "Поиск человека";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxIsDoctor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSelectPerson;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Button buttonBirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}