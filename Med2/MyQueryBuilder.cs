using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med2
{
    public partial class MyQueryBuilder : Form
    {

        public static string[][] Fields = new string[10][];
        static int EntityIndex = -1, field1 = -1, field2 = -1, field3 = -1;

        private void comboBoxField1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxField1.SelectedIndex;

            if (comboBoxField2.Items.Count == 0)
                comboBoxField2.Items.AddRange(Fields[EntityIndex]);


            if (comboBoxField2.Items.Contains(comboBoxField1.Items[index]))
            {
                if (Array.IndexOf(Fields[EntityIndex], comboBoxField2.Items[comboBoxField2.Items.IndexOf(comboBoxField1.Items[index])]) == field2)
                {
                    field2 = -1;
                    field3 = -1;
                    comboBoxField3.Items.Clear();
                }
                comboBoxField2.Items.Remove(comboBoxField1.Items[index]);

                if (field1 != -1)
                    comboBoxField2.Items.Add(Fields[EntityIndex][field1]);
            }



            if (comboBoxField3.Items.Count != 0)
                if (comboBoxField3.Items.Contains(comboBoxField1.Items[index]))
                {
                    comboBoxField3.Items.Remove(comboBoxField1.Items[index]);
                    comboBoxField3.Items.Add(Fields[EntityIndex][field1]);
                }

            if (comboBoxField3.SelectedItem == null)
                field3 = -1;

            if (comboBoxField2.SelectedItem == null)
                field2 = -1;

            field1 = comboBoxField1.SelectedIndex;
        }

        private void comboBoxField2_SelectedIndexChanged(object sender, EventArgs e)
        {   
            int index1 = comboBoxField1.SelectedIndex;
            int index2 = comboBoxField2.SelectedIndex;

            if (comboBoxField3.Items.Count == 0)
            {
                comboBoxField3.Items.AddRange(Fields[EntityIndex]);
                comboBoxField3.Items.Remove(comboBoxField1.Items[index1]);
                comboBoxField3.Items.Remove(comboBoxField2.Items[index2]);
            }

            if (comboBoxField3.Items.Contains(comboBoxField2.Items[index2]))
            {
                comboBoxField3.Items.Remove(comboBoxField2.Items[index2]);

                if (field2 != -1)
                    comboBoxField3.Items.Add(Fields[EntityIndex][field2]);
            }

            if (comboBoxField3.SelectedItem == null)
                field3 = -1;

            field2 = Array.IndexOf(Fields[EntityIndex], comboBoxField2.Items[index2]);
        }

        private void comboBoxField3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxField3.SelectedIndex;
            field3 = Array.IndexOf(Fields[EntityIndex], comboBoxField3.Items[index]);
        }

        //Человек                       0
        //Доктор                        1
        //Пациент                       2
        //Медицинская карта             3
        //Болезнь                       4
        //Запись на приём               5
        //Запись врача                  6
        //Свободное время               7
        //Занятое время                 8
        //Документы                     9

        public MyQueryBuilder()
        {
            InitializeComponent();
        }

        private void MyQueryBuilder_Load(object sender, EventArgs e)
        {
            Fields[0] = new string[] { "Полное имя", "Возраст", "Дата рождения", "Место просписки" };
            Fields[1] = new string[] { "Полное имя", "Возраст", "Дата рождения", "Место просписки", "Должность", "Свободное время" };
            Fields[2] = new string[] { "Полное имя", "Возраст", "Дата рождения", "Место просписки", "Имеет болезнь" };
            Fields[3] = new string[] { "Число записей", "Имя владельца" };
            Fields[4] = new string[] { "Число больных", "Название болезни" };
            Fields[5] = new string[] { "День приёма", "Имя врача", "Имя пациента" };
            Fields[6] = new string[] { "День записи", "Имя врача", "Имя пациента" };
            Fields[7] = new string[] { "Свободное время", "Имя врача" };
            Fields[8] = new string[] { "Занятое время", "Имя врача" };
            Fields[9] = new string[] { "Тип документа", "Номер"};
        }

        private void comboBoxEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityIndex = comboBoxEntities.SelectedIndex;
            comboBoxField1.Items.Clear();
            comboBoxField2.Items.Clear();
            comboBoxField3.Items.Clear();
            textBoxField1.Clear();
            textBoxField2.Clear();
            textBoxField3.Clear();
            field1 = -1;
            field2 = -1;
            field3 = -1;

            comboBoxField1.Items.AddRange(Fields[EntityIndex]);
            //comboBoxField2.Items.AddRange(Fields[EntityIndex]);
            //comboBoxField3.Items.AddRange(Fields[EntityIndex]);
        }
            
        
    }
}


/*
 * 
 * Разработчик запросов:
1. Создано меню
2. Возможность переключать
 * 
 * 
 * switch (index)
            {
                //Человек
                case 0:
                    {
                       
                    }
                    break;

                //Доктор
                case 1:
                    {
                       
                    }
                    break;

                //Пациент
                case 2:
                    {
                     
                    }
                    break;

                //Медицинская карта
                case 3:
                    {
                      
                    }
                    break;

                //Болезнь
                case 4:
                    {
                       
                    }
                    break;

                //Запись на приём
                case 5:
                    {
                     
                    }
                    break;

                //Запись врача
                case 6:
                    {
                       
                    }
                    break;

                //Свободное время
                case 7:
                    {
                      
                    }
                    break;

                //Занятое время
                case 8:
                    {
                       
                    }
                    break;

                //Документы
                case 9:
                    {
                        
                    }
                    break;
            }
*/
