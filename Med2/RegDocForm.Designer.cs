namespace Med2
{
    partial class RegDocForm
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
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxInsuranceBillNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textDocumentN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textRegAdress = new System.Windows.Forms.TextBox();
            this.textLiveAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textName2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Items.AddRange(new object[] {
            "Паспорт гражданина РФ",
            "Свидетельство о рождении",
            "Дипломатический паспорт",
            "Паспорт моряка",
            "Военный билет",
            "Удостоверение личности военнослужащего",
            "Удостоверение беженца",
            "Служебное удостоверение работника прокуратуры"});
            this.comboBoxDocType.Location = new System.Drawing.Point(145, 407);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(137, 21);
            this.comboBoxDocType.TabIndex = 75;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(145, 92);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(137, 21);
            this.comboBoxGender.TabIndex = 74;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(24, 655);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(264, 20);
            this.textBoxPassword2.TabIndex = 71;
            this.textBoxPassword2.Text = "a";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 639);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Повторите";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(24, 609);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(264, 20);
            this.textBoxPassword1.TabIndex = 69;
            this.textBoxPassword1.Text = "a";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 593);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Введите пароль";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 575);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 67;
            this.label18.Text = "Пароль:";
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(24, 693);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(264, 23);
            this.buttonReg.TabIndex = 66;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            // 
            // textBoxInsuranceBillNum
            // 
            this.textBoxInsuranceBillNum.Location = new System.Drawing.Point(24, 500);
            this.textBoxInsuranceBillNum.Name = "textBoxInsuranceBillNum";
            this.textBoxInsuranceBillNum.Size = new System.Drawing.Size(264, 20);
            this.textBoxInsuranceBillNum.TabIndex = 63;
            this.textBoxInsuranceBillNum.Text = "a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 484);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Страховой номер индивидуального лицевого счёта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "При наличии:";
            // 
            // textDocumentN
            // 
            this.textDocumentN.Location = new System.Drawing.Point(145, 433);
            this.textDocumentN.Name = "textDocumentN";
            this.textDocumentN.Size = new System.Drawing.Size(137, 20);
            this.textDocumentN.TabIndex = 60;
            this.textDocumentN.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Номер документа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Удостоверение личности:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Вид документа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Дата регистрации";
            // 
            // dateTimePickerRegDate
            // 
            this.dateTimePickerRegDate.Location = new System.Drawing.Point(145, 239);
            this.dateTimePickerRegDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerRegDate.Name = "dateTimePickerRegDate";
            this.dateTimePickerRegDate.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerRegDate.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Место регистрации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Место жительства";
            // 
            // textRegAdress
            // 
            this.textRegAdress.Location = new System.Drawing.Point(145, 213);
            this.textRegAdress.Name = "textRegAdress";
            this.textRegAdress.Size = new System.Drawing.Size(137, 20);
            this.textRegAdress.TabIndex = 52;
            this.textRegAdress.Text = "a";
            // 
            // textLiveAdress
            // 
            this.textLiveAdress.Location = new System.Drawing.Point(145, 187);
            this.textLiveAdress.Name = "textLiveAdress";
            this.textLiveAdress.Size = new System.Drawing.Size(137, 20);
            this.textLiveAdress.TabIndex = 51;
            this.textLiveAdress.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Гражданство";
            // 
            // textNation
            // 
            this.textNation.Location = new System.Drawing.Point(145, 161);
            this.textNation.Name = "textNation";
            this.textNation.Size = new System.Drawing.Size(137, 20);
            this.textNation.TabIndex = 49;
            this.textNation.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Дата рождения";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(145, 121);
            this.dateTimePickerBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerBirthDate.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Фамилия";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(145, 14);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(137, 20);
            this.textSurname.TabIndex = 43;
            this.textSurname.Text = "a";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(145, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(137, 20);
            this.textName.TabIndex = 42;
            this.textName.Text = "a";
            // 
            // textName2
            // 
            this.textName2.Location = new System.Drawing.Point(145, 66);
            this.textName2.Name = "textName2";
            this.textName2.Size = new System.Drawing.Size(137, 20);
            this.textName2.TabIndex = 41;
            this.textName2.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Пол";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 546);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 77;
            this.textBox1.Text = "a";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(21, 530);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Сведения о членстве в мед. проф. неком-их орг-иях";
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Items.AddRange(new object[] {
            "Паспорт гражданина РФ",
            "Свидетельство о рождении",
            "Дипломатический паспорт",
            "Паспорт моряка",
            "Военный билет",
            "Удостоверение личности военнослужащего",
            "Удостоверение беженца",
            "Служебное удостоверение работника прокуратуры"});
            this.comboBoxJob.Location = new System.Drawing.Point(145, 265);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(137, 21);
            this.comboBoxJob.TabIndex = 78;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 268);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 79;
            this.label19.Text = "Должность";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 297);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 80;
            this.label20.Text = "Образование";
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.Location = new System.Drawing.Point(145, 294);
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(137, 20);
            this.textBoxEducation.TabIndex = 81;
            this.textBoxEducation.Text = "a";
            // 
            // RegDocForm
            // 
            this.ClientSize = new System.Drawing.Size(306, 741);
            this.Controls.Add(this.textBoxEducation);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBoxJob);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxPassword1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxInsuranceBillNum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textDocumentN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerRegDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textRegAdress);
            this.Controls.Add(this.textLiveAdress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textName2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(322, 780);
            this.MinimumSize = new System.Drawing.Size(322, 39);
            this.Name = "RegDocForm";
            this.Text = "Добавление врача";
            this.Load += new System.EventHandler(this.RegDocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxDocType;
        public System.Windows.Forms.ComboBox comboBoxGender;
        public System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonReg;
        public System.Windows.Forms.TextBox textBoxInsuranceBillNum;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox textDocumentN;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dateTimePickerRegDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textRegAdress;
        public System.Windows.Forms.TextBox textLiveAdress;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textNation;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textSurname;
        public System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.TextBox textName2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox comboBoxJob;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox textBoxEducation;
    }
}