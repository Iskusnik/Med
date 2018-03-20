namespace Med2
{
    partial class ChangeMedCard
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
            this.dataGWVisitInfo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDocRecs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddIllness = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGWIllness = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWVisitInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocRecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWIllness)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGWVisitInfo
            // 
            this.dataGWVisitInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGWVisitInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGWVisitInfo.Location = new System.Drawing.Point(486, 33);
            this.dataGWVisitInfo.Name = "dataGWVisitInfo";
            this.dataGWVisitInfo.ReadOnly = true;
            this.dataGWVisitInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGWVisitInfo.Size = new System.Drawing.Size(99, 188);
            this.dataGWVisitInfo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Новая запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Прошедшие приёмы";
            // 
            // dataGridViewDocRecs
            // 
            this.dataGridViewDocRecs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocRecs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocRecs.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewDocRecs.Name = "dataGridViewDocRecs";
            this.dataGridViewDocRecs.ReadOnly = true;
            this.dataGridViewDocRecs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDocRecs.Size = new System.Drawing.Size(277, 161);
            this.dataGridViewDocRecs.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Записи врачей";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Болезни";
            // 
            // buttonAddIllness
            // 
            this.buttonAddIllness.Location = new System.Drawing.Point(313, 198);
            this.buttonAddIllness.Name = "buttonAddIllness";
            this.buttonAddIllness.Size = new System.Drawing.Size(73, 23);
            this.buttonAddIllness.TabIndex = 13;
            this.buttonAddIllness.Text = "Добавить";
            this.buttonAddIllness.UseVisualStyleBackColor = true;
            this.buttonAddIllness.Click += new System.EventHandler(this.buttonAddIllness_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // dataGWIllness
            // 
            this.dataGWIllness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGWIllness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGWIllness.Location = new System.Drawing.Point(313, 31);
            this.dataGWIllness.Name = "dataGWIllness";
            this.dataGWIllness.ReadOnly = true;
            this.dataGWIllness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGWIllness.Size = new System.Drawing.Size(167, 134);
            this.dataGWIllness.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Подробнее";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(392, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ChangeMedCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 237);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddIllness);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGWIllness);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewDocRecs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGWVisitInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeMedCard";
            this.Text = "Медицинская карта";
            this.Load += new System.EventHandler(this.ChangeMedCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGWVisitInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocRecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWIllness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGWVisitInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDocRecs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddIllness;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGWIllness;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}