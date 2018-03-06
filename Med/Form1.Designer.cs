namespace Med
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medDB1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDB1DataSet = new Med.MedDB1DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.врачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.медкартаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьОПриёмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.записьНаПриёмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьМедкартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входВСистемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВыборкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перенестиВdocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDB1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDB1DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 443);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.medDB1DataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // medDB1DataSetBindingSource
            // 
            this.medDB1DataSetBindingSource.DataSource = this.medDB1DataSet;
            this.medDB1DataSetBindingSource.Position = 0;
            // 
            // medDB1DataSet
            // 
            this.medDB1DataSet.DataSetName = "MedDB1DataSet";
            this.medDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входВСистемуToolStripMenuItem,
            this.врачиToolStripMenuItem,
            this.пациентToolStripMenuItem,
            this.отчётToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // врачиToolStripMenuItem
            // 
            this.врачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВрачаToolStripMenuItem,
            this.удалитьToolStripMenuItem1,
            this.медкартаToolStripMenuItem1});
            this.врачиToolStripMenuItem.Name = "врачиToolStripMenuItem";
            this.врачиToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.врачиToolStripMenuItem.Text = "Врач";
            // 
            // добавитьВрачаToolStripMenuItem
            // 
            this.добавитьВрачаToolStripMenuItem.Name = "добавитьВрачаToolStripMenuItem";
            this.добавитьВрачаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьВрачаToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // медкартаToolStripMenuItem1
            // 
            this.медкартаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem2,
            this.редактироватьToolStripMenuItem,
            this.записьОПриёмеToolStripMenuItem,
            this.перенестиВdocToolStripMenuItem});
            this.медкартаToolStripMenuItem1.Name = "медкартаToolStripMenuItem1";
            this.медкартаToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.медкартаToolStripMenuItem1.Text = "Мед.карта";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формаToolStripMenuItem1,
            this.файлToolStripMenuItem1});
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // записьОПриёмеToolStripMenuItem
            // 
            this.записьОПриёмеToolStripMenuItem.Name = "записьОПриёмеToolStripMenuItem";
            this.записьОПриёмеToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.записьОПриёмеToolStripMenuItem.Text = "Запись о приёме";
            // 
            // формаToolStripMenuItem1
            // 
            this.формаToolStripMenuItem1.Name = "формаToolStripMenuItem1";
            this.формаToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.формаToolStripMenuItem1.Text = "Форма";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // записьНаПриёмToolStripMenuItem
            // 
            this.записьНаПриёмToolStripMenuItem.Name = "записьНаПриёмToolStripMenuItem";
            this.записьНаПриёмToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.записьНаПриёмToolStripMenuItem.Text = "Запись на приём";
            // 
            // отменаЗаписиToolStripMenuItem
            // 
            this.отменаЗаписиToolStripMenuItem.Name = "отменаЗаписиToolStripMenuItem";
            this.отменаЗаписиToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.отменаЗаписиToolStripMenuItem.Text = "Отмена записи";
            // 
            // открытьМедкартуToolStripMenuItem
            // 
            this.открытьМедкартуToolStripMenuItem.Name = "открытьМедкартуToolStripMenuItem";
            this.открытьМедкартуToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.открытьМедкартуToolStripMenuItem.Text = "Открыть мед.карту";
            // 
            // пациентToolStripMenuItem
            // 
            this.пациентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записьНаПриёмToolStripMenuItem,
            this.отменаЗаписиToolStripMenuItem,
            this.открытьМедкартуToolStripMenuItem});
            this.пациентToolStripMenuItem.Name = "пациентToolStripMenuItem";
            this.пациентToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.пациентToolStripMenuItem.Text = "Пациент";
            // 
            // входВСистемуToolStripMenuItem
            // 
            this.входВСистемуToolStripMenuItem.Name = "входВСистемуToolStripMenuItem";
            this.входВСистемуToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.входВСистемуToolStripMenuItem.Text = "Вход в систему";
            this.входВСистемуToolStripMenuItem.Click += new System.EventHandler(this.входВСистемуToolStripMenuItem_Click);
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйЗапросToolStripMenuItem,
            this.сохранитьВыборкуToolStripMenuItem});
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // новыйЗапросToolStripMenuItem
            // 
            this.новыйЗапросToolStripMenuItem.Name = "новыйЗапросToolStripMenuItem";
            this.новыйЗапросToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.новыйЗапросToolStripMenuItem.Text = "Новый запрос";
            // 
            // сохранитьВыборкуToolStripMenuItem
            // 
            this.сохранитьВыборкуToolStripMenuItem.Name = "сохранитьВыборкуToolStripMenuItem";
            this.сохранитьВыборкуToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.сохранитьВыборкуToolStripMenuItem.Text = "Сохранить как *.xls";
            // 
            // перенестиВdocToolStripMenuItem
            // 
            this.перенестиВdocToolStripMenuItem.Name = "перенестиВdocToolStripMenuItem";
            this.перенестиВdocToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.перенестиВdocToolStripMenuItem.Text = "Сохранить как *.doc";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 443);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Поликлиника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDB1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDB1DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource medDB1DataSetBindingSource;
        private MedDB1DataSet medDB1DataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem врачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВрачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem медкартаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem формаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьОПриёмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьНаПриёмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьМедкартуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входВСистемуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВыборкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перенестиВdocToolStripMenuItem;
    }
}

