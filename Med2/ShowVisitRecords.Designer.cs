namespace Med2
{
    partial class ShowVisitRecords
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
            this.newMedDBDataSet = new Med2.NewMedDBDataSet();
            this.visitInfoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitInfoSetTableAdapter = new Med2.NewMedDBDataSetTableAdapters.VisitInfoSetTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.newMedDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitInfoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // newMedDBDataSet
            // 
            this.newMedDBDataSet.DataSetName = "NewMedDBDataSet";
            this.newMedDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitInfoSetBindingSource
            // 
            this.visitInfoSetBindingSource.DataMember = "VisitInfoSet";
            this.visitInfoSetBindingSource.DataSource = this.newMedDBDataSet;
            // 
            // visitInfoSetTableAdapter
            // 
            this.visitInfoSetTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все посещения к врачу",
            "Грядущие посещения",
            "Прошедшие посещения"});
            this.comboBox1.Location = new System.Drawing.Point(13, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // ShowVisitRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 278);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowVisitRecords";
            this.Text = "ShowVisitRecords";
            this.Load += new System.EventHandler(this.ShowVisitRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newMedDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitInfoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NewMedDBDataSet newMedDBDataSet;
        private System.Windows.Forms.BindingSource visitInfoSetBindingSource;
        private NewMedDBDataSetTableAdapters.VisitInfoSetTableAdapter visitInfoSetTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}