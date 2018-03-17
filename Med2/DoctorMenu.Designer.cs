﻿namespace Med2
{
    partial class DoctorMenu
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
            this.редактироватьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьИсториюЗаписейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приёмКВрачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxDocType = new System.Windows.Forms.TextBox();
            this.textBoxRegDate = new System.Windows.Forms.TextBox();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxBloodType = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxWorkIncapacity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textInsurancePolicyNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxInsuranceBillNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textDocumentN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textRegAdress = new System.Windows.Forms.TextBox();
            this.textLiveAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.изменитьРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // редактироватьДанныеToolStripMenuItem
            // 
            this.редактироватьДанныеToolStripMenuItem.Name = "редактироватьДанныеToolStripMenuItem";
            this.редактироватьДанныеToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.редактироватьДанныеToolStripMenuItem.Text = "Медицинская карта";
            // 
            // просмотретьИсториюЗаписейToolStripMenuItem
            // 
            this.просмотретьИсториюЗаписейToolStripMenuItem.Name = "просмотретьИсториюЗаписейToolStripMenuItem";
            this.просмотретьИсториюЗаписейToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.просмотретьИсториюЗаписейToolStripMenuItem.Text = "Просмотреть историю приёмов";
            // 
            // записатьсяToolStripMenuItem
            // 
            this.записатьсяToolStripMenuItem.Name = "записатьсяToolStripMenuItem";
            this.записатьсяToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.записатьсяToolStripMenuItem.Text = "Добавить врача";
            this.записатьсяToolStripMenuItem.Click += new System.EventHandler(this.записатьсяToolStripMenuItem_Click);
            // 
            // приёмКВрачуToolStripMenuItem
            // 
            this.приёмКВрачуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатьсяToolStripMenuItem,
            this.просмотретьИсториюЗаписейToolStripMenuItem,
            this.изменитьРасписаниеToolStripMenuItem});
            this.приёмКВрачуToolStripMenuItem.Name = "приёмКВрачуToolStripMenuItem";
            this.приёмКВрачуToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.приёмКВрачуToolStripMenuItem.Text = "Управление поликлиникой";
            // 
            // textBoxDocType
            // 
            this.textBoxDocType.Location = new System.Drawing.Point(561, 62);
            this.textBoxDocType.Name = "textBoxDocType";
            this.textBoxDocType.ReadOnly = true;
            this.textBoxDocType.Size = new System.Drawing.Size(180, 20);
            this.textBoxDocType.TabIndex = 113;
            this.textBoxDocType.Text = "a";
            // 
            // textBoxRegDate
            // 
            this.textBoxRegDate.Location = new System.Drawing.Point(154, 245);
            this.textBoxRegDate.Name = "textBoxRegDate";
            this.textBoxRegDate.ReadOnly = true;
            this.textBoxRegDate.Size = new System.Drawing.Size(223, 20);
            this.textBoxRegDate.TabIndex = 112;
            this.textBoxRegDate.Text = "a";
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(154, 115);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.ReadOnly = true;
            this.textBoxBirthDate.Size = new System.Drawing.Size(223, 20);
            this.textBoxBirthDate.TabIndex = 111;
            this.textBoxBirthDate.Text = "a";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(154, 89);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(223, 20);
            this.textBoxGender.TabIndex = 110;
            this.textBoxGender.Text = "a";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 109;
            this.label17.Text = "Группа крови";
            // 
            // textBoxBloodType
            // 
            this.textBoxBloodType.Location = new System.Drawing.Point(154, 290);
            this.textBoxBloodType.Name = "textBoxBloodType";
            this.textBoxBloodType.ReadOnly = true;
            this.textBoxBloodType.Size = new System.Drawing.Size(223, 20);
            this.textBoxBloodType.TabIndex = 108;
            this.textBoxBloodType.Text = "a";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 107;
            this.label16.Text = "Общие сведения";
            // 
            // textBoxWorkIncapacity
            // 
            this.textBoxWorkIncapacity.Location = new System.Drawing.Point(440, 247);
            this.textBoxWorkIncapacity.Name = "textBoxWorkIncapacity";
            this.textBoxWorkIncapacity.ReadOnly = true;
            this.textBoxWorkIncapacity.Size = new System.Drawing.Size(301, 20);
            this.textBoxWorkIncapacity.TabIndex = 105;
            this.textBoxWorkIncapacity.Text = "a";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(437, 231);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(228, 13);
            this.label19.TabIndex = 104;
            this.label19.Text = "Серия и номер листка нетрудоспособности";
            // 
            // textInsurancePolicyNum
            // 
            this.textInsurancePolicyNum.Location = new System.Drawing.Point(440, 195);
            this.textInsurancePolicyNum.Name = "textInsurancePolicyNum";
            this.textInsurancePolicyNum.ReadOnly = true;
            this.textInsurancePolicyNum.Size = new System.Drawing.Size(301, 20);
            this.textInsurancePolicyNum.TabIndex = 103;
            this.textInsurancePolicyNum.Text = "a";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(437, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 102;
            this.label15.Text = "Номер полиса ОМС";
            // 
            // textBoxInsuranceBillNum
            // 
            this.textBoxInsuranceBillNum.Location = new System.Drawing.Point(440, 147);
            this.textBoxInsuranceBillNum.Name = "textBoxInsuranceBillNum";
            this.textBoxInsuranceBillNum.ReadOnly = true;
            this.textBoxInsuranceBillNum.Size = new System.Drawing.Size(301, 20);
            this.textBoxInsuranceBillNum.TabIndex = 101;
            this.textBoxInsuranceBillNum.Text = "a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(437, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 13);
            this.label14.TabIndex = 100;
            this.label14.Text = "Страховой номер индивидуального лицевого счёта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(428, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 99;
            this.label13.Text = "При наличии:";
            // 
            // textDocumentN
            // 
            this.textDocumentN.Location = new System.Drawing.Point(561, 88);
            this.textDocumentN.Name = "textDocumentN";
            this.textDocumentN.ReadOnly = true;
            this.textDocumentN.Size = new System.Drawing.Size(180, 20);
            this.textDocumentN.TabIndex = 98;
            this.textDocumentN.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 97;
            this.label12.Text = "Номер документа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(429, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Удостоверение личности:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Вид документа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "Дата регистрации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Место регистрации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Место жительства";
            // 
            // textRegAdress
            // 
            this.textRegAdress.Location = new System.Drawing.Point(154, 219);
            this.textRegAdress.Name = "textRegAdress";
            this.textRegAdress.ReadOnly = true;
            this.textRegAdress.Size = new System.Drawing.Size(223, 20);
            this.textRegAdress.TabIndex = 91;
            this.textRegAdress.Text = "a";
            // 
            // textLiveAdress
            // 
            this.textLiveAdress.Location = new System.Drawing.Point(154, 193);
            this.textLiveAdress.Name = "textLiveAdress";
            this.textLiveAdress.ReadOnly = true;
            this.textLiveAdress.Size = new System.Drawing.Size(223, 20);
            this.textLiveAdress.TabIndex = 90;
            this.textLiveAdress.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Гражданство";
            // 
            // textNation
            // 
            this.textNation.Location = new System.Drawing.Point(154, 167);
            this.textNation.Name = "textNation";
            this.textNation.ReadOnly = true;
            this.textNation.Size = new System.Drawing.Size(223, 20);
            this.textNation.TabIndex = 88;
            this.textNation.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "ФИО";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(154, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(223, 20);
            this.textBoxName.TabIndex = 85;
            this.textBoxName.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Пол";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приёмКВрачуToolStripMenuItem,
            this.редактироватьДанныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 106;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // изменитьРасписаниеToolStripMenuItem
            // 
            this.изменитьРасписаниеToolStripMenuItem.Name = "изменитьРасписаниеToolStripMenuItem";
            this.изменитьРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.изменитьРасписаниеToolStripMenuItem.Text = "Изменить расписание";
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 340);
            this.Controls.Add(this.textBoxDocType);
            this.Controls.Add(this.textBoxRegDate);
            this.Controls.Add(this.textBoxBirthDate);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxBloodType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxWorkIncapacity);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textInsurancePolicyNum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxInsuranceBillNum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textDocumentN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textRegAdress);
            this.Controls.Add(this.textLiveAdress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DoctorMenu";
            this.Text = "Врач: ";
            this.Load += new System.EventHandler(this.DoctorMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem редактироватьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьИсториюЗаписейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приёмКВрачуToolStripMenuItem;
        public System.Windows.Forms.TextBox textBoxDocType;
        public System.Windows.Forms.TextBox textBoxRegDate;
        public System.Windows.Forms.TextBox textBoxBirthDate;
        public System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox textBoxBloodType;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox textBoxWorkIncapacity;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox textInsurancePolicyNum;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textBoxInsuranceBillNum;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox textDocumentN;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textRegAdress;
        public System.Windows.Forms.TextBox textLiveAdress;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textNation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьРасписаниеToolStripMenuItem;
    }
}