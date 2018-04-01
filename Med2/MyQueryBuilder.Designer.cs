namespace Med2
{
    partial class MyQueryBuilder
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
            this.comboBoxEntities = new System.Windows.Forms.ComboBox();
            this.comboBoxField1 = new System.Windows.Forms.ComboBox();
            this.textBoxField1 = new System.Windows.Forms.TextBox();
            this.textBoxField2 = new System.Windows.Forms.TextBox();
            this.comboBoxField2 = new System.Windows.Forms.ComboBox();
            this.comboBox1or_and2 = new System.Windows.Forms.ComboBox();
            this.textBoxField3 = new System.Windows.Forms.TextBox();
            this.comboBoxField3 = new System.Windows.Forms.ComboBox();
            this.comboBox12_and_or3 = new System.Windows.Forms.ComboBox();
            this.comboBoxEqual1 = new System.Windows.Forms.ComboBox();
            this.comboBoxEqual2 = new System.Windows.Forms.ComboBox();
            this.comboBoxEqual3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonToExcel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEntities
            // 
            this.comboBoxEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntities.FormattingEnabled = true;
            this.comboBoxEntities.Items.AddRange(new object[] {
            "Все персональные данные",
            "Доктора",
            "Пациенты",
            "Медицинская карта",
            "Болезнь",
            "Запись на приём",
            "Запись врача",
            "Свободное время",
            "Занятое время",
            "Документы"});
            this.comboBoxEntities.Location = new System.Drawing.Point(13, 13);
            this.comboBoxEntities.Name = "comboBoxEntities";
            this.comboBoxEntities.Size = new System.Drawing.Size(221, 21);
            this.comboBoxEntities.TabIndex = 0;
            this.comboBoxEntities.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntities_SelectedIndexChanged);
            // 
            // comboBoxField1
            // 
            this.comboBoxField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxField1.FormattingEnabled = true;
            this.comboBoxField1.Location = new System.Drawing.Point(13, 85);
            this.comboBoxField1.Name = "comboBoxField1";
            this.comboBoxField1.Size = new System.Drawing.Size(221, 21);
            this.comboBoxField1.TabIndex = 2;
            this.comboBoxField1.SelectedIndexChanged += new System.EventHandler(this.comboBoxField1_SelectedIndexChanged);
            // 
            // textBoxField1
            // 
            this.textBoxField1.Location = new System.Drawing.Point(94, 113);
            this.textBoxField1.Name = "textBoxField1";
            this.textBoxField1.Size = new System.Drawing.Size(140, 20);
            this.textBoxField1.TabIndex = 3;
            // 
            // textBoxField2
            // 
            this.textBoxField2.Location = new System.Drawing.Point(94, 202);
            this.textBoxField2.Name = "textBoxField2";
            this.textBoxField2.Size = new System.Drawing.Size(141, 20);
            this.textBoxField2.TabIndex = 6;
            // 
            // comboBoxField2
            // 
            this.comboBoxField2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxField2.FormattingEnabled = true;
            this.comboBoxField2.Location = new System.Drawing.Point(13, 175);
            this.comboBoxField2.Name = "comboBoxField2";
            this.comboBoxField2.Size = new System.Drawing.Size(223, 21);
            this.comboBoxField2.TabIndex = 5;
            this.comboBoxField2.SelectedIndexChanged += new System.EventHandler(this.comboBoxField2_SelectedIndexChanged);
            // 
            // comboBox1or_and2
            // 
            this.comboBox1or_and2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1or_and2.FormattingEnabled = true;
            this.comboBox1or_and2.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.comboBox1or_and2.Location = new System.Drawing.Point(13, 148);
            this.comboBox1or_and2.Name = "comboBox1or_and2";
            this.comboBox1or_and2.Size = new System.Drawing.Size(76, 21);
            this.comboBox1or_and2.TabIndex = 4;
            // 
            // textBoxField3
            // 
            this.textBoxField3.Location = new System.Drawing.Point(93, 294);
            this.textBoxField3.Name = "textBoxField3";
            this.textBoxField3.Size = new System.Drawing.Size(141, 20);
            this.textBoxField3.TabIndex = 9;
            // 
            // comboBoxField3
            // 
            this.comboBoxField3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxField3.FormattingEnabled = true;
            this.comboBoxField3.Location = new System.Drawing.Point(13, 266);
            this.comboBoxField3.Name = "comboBoxField3";
            this.comboBoxField3.Size = new System.Drawing.Size(221, 21);
            this.comboBoxField3.TabIndex = 8;
            this.comboBoxField3.SelectedIndexChanged += new System.EventHandler(this.comboBoxField3_SelectedIndexChanged);
            // 
            // comboBox12_and_or3
            // 
            this.comboBox12_and_or3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12_and_or3.FormattingEnabled = true;
            this.comboBox12_and_or3.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.comboBox12_and_or3.Location = new System.Drawing.Point(13, 239);
            this.comboBox12_and_or3.Name = "comboBox12_and_or3";
            this.comboBox12_and_or3.Size = new System.Drawing.Size(76, 21);
            this.comboBox12_and_or3.TabIndex = 7;
            // 
            // comboBoxEqual1
            // 
            this.comboBoxEqual1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEqual1.FormattingEnabled = true;
            this.comboBoxEqual1.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this.comboBoxEqual1.Location = new System.Drawing.Point(13, 113);
            this.comboBoxEqual1.Name = "comboBoxEqual1";
            this.comboBoxEqual1.Size = new System.Drawing.Size(76, 21);
            this.comboBoxEqual1.TabIndex = 10;
            // 
            // comboBoxEqual2
            // 
            this.comboBoxEqual2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEqual2.FormattingEnabled = true;
            this.comboBoxEqual2.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this.comboBoxEqual2.Location = new System.Drawing.Point(13, 202);
            this.comboBoxEqual2.Name = "comboBoxEqual2";
            this.comboBoxEqual2.Size = new System.Drawing.Size(76, 21);
            this.comboBoxEqual2.TabIndex = 11;
            // 
            // comboBoxEqual3
            // 
            this.comboBoxEqual3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEqual3.FormattingEnabled = true;
            this.comboBoxEqual3.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this.comboBoxEqual3.Location = new System.Drawing.Point(13, 293);
            this.comboBoxEqual3.Name = "comboBoxEqual3";
            this.comboBoxEqual3.Size = new System.Drawing.Size(76, 21);
            this.comboBoxEqual3.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 274);
            this.dataGridView1.TabIndex = 13;
            // 
            // buttonToExcel
            // 
            this.buttonToExcel.Location = new System.Drawing.Point(257, 291);
            this.buttonToExcel.Name = "buttonToExcel";
            this.buttonToExcel.Size = new System.Drawing.Size(340, 23);
            this.buttonToExcel.TabIndex = 14;
            this.buttonToExcel.Text = "Выгрузить в xls";
            this.buttonToExcel.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(224, 23);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // MyQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 326);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonToExcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxEqual3);
            this.Controls.Add(this.comboBoxEqual2);
            this.Controls.Add(this.comboBoxEqual1);
            this.Controls.Add(this.textBoxField3);
            this.Controls.Add(this.comboBoxField3);
            this.Controls.Add(this.comboBox12_and_or3);
            this.Controls.Add(this.textBoxField2);
            this.Controls.Add(this.comboBoxField2);
            this.Controls.Add(this.comboBox1or_and2);
            this.Controls.Add(this.textBoxField1);
            this.Controls.Add(this.comboBoxField1);
            this.Controls.Add(this.comboBoxEntities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyQueryBuilder";
            this.Text = "Конструктор запросов";
            this.Load += new System.EventHandler(this.MyQueryBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEntities;
        private System.Windows.Forms.ComboBox comboBoxField1;
        private System.Windows.Forms.TextBox textBoxField1;
        private System.Windows.Forms.TextBox textBoxField2;
        private System.Windows.Forms.ComboBox comboBoxField2;
        private System.Windows.Forms.ComboBox comboBox1or_and2;
        private System.Windows.Forms.TextBox textBoxField3;
        private System.Windows.Forms.ComboBox comboBoxField3;
        private System.Windows.Forms.ComboBox comboBox12_and_or3;
        private System.Windows.Forms.ComboBox comboBoxEqual1;
        private System.Windows.Forms.ComboBox comboBoxEqual2;
        private System.Windows.Forms.ComboBox comboBoxEqual3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonToExcel;
        private System.Windows.Forms.Button buttonSearch;
    }
}