using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Med2
{
    public class ControlFunctions
    {

        //static string connectionString = ConfigurationManager.ConnectionStrings["Med.Properties.Settings.LastMedDBConnectionString"].ConnectionString;
        //public static SqlConnection connection = new SqlConnection(connectionString);
        //static public LastMedDBDataSet db = new LastMedDBDataSet();
        //db.PersonSet_Operator.FindByBirthDateNameHashID()
        public static string connectionString = @"Data Source=ISKUSNIK;Initial Catalog=NewMedDB;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        

        public static bool LoginPasswordCheck(string login, string password)
        {
            using (connection)
            {
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    connection.Open();
                    
                    db.PersonSet.Add(new Patient { FullName = "Фёдоров Фёдор Фёдорович" });
                    db.PersonSet.Add(new Patient { FullName = "Иванов Фёдор Фёдорович" });
                    db.SaveChanges();
                    return false;
                }
            }
        }
        public static bool RegistrationCall(object obj)
        {
            RegForm regForm = (RegForm)obj;
            
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                Patient newPatient = new Patient();
                try
                {
                    if (regForm.comboBoxGender.Text == "" || regForm.textSurname.Text == "" 
                          || regForm.textName.Text == "" || regForm.textBoxPassword2.Text == ""
                          || regForm.textNation.Text == "" || regForm.textLiveAdress.Text == ""
                          || regForm.textRegAdress.Text == ""  || regForm.textDocument.Text == "" 
                          || regForm.textDocumentN.Text == "" || regForm.textBoxPassword1.Text == "")
                        throw (new ArgumentNullException());

                    newPatient.FullName = regForm.textSurname.Text + " " + regForm.textName.Text + " " + regForm.textName2.Text;
                    newPatient.Gender = regForm.comboBoxGender.Text;
                    newPatient.BirthDate = regForm.dateTimePickerBirthDate.Value.Date;
                    newPatient.Nationality = regForm.textNation.Text;
                    newPatient.LiveAdress = regForm.textLiveAdress.Text;
                    newPatient.RegAdress = regForm.textRegAdress.Text;
                    newPatient.RegDate = regForm.dateTimePickerRegDate.Value.Date;
                    newPatient.InsuranceBillNum = regForm.textBoxInsuranceBillNum.Text;
                    newPatient.InsurancePolicyNum = regForm.textInsurancePolicyNum.Text;
                    newPatient.WorkIncapacityListNum = regForm.textBoxWorkIncapacity.Text;
                    newPatient.BloodType = 0;
                    newPatient.Rhesus = "Неизвестно";
                    newPatient.NameHashID = newPatient.FullName.GetHashCode();
                    try
                    {
                        newPatient.Documents = new Documents { DocumentName = regForm.textDocument.Text, Id = long.Parse(regForm.textDocumentN.Text), Person = newPatient };   
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("В номере документа могут быть только цифры");
                    }
                    if (regForm.textBoxPassword1.Text == regForm.textBoxPassword2.Text)
                        newPatient.Password = regForm.textBoxPassword1.Text;
                    else
                        throw new Exception("Пароль не совпадает с введённым во второй раз");

                    if (db.PersonSet.Find(newPatient.BirthDate, newPatient.NameHashID) != null)
                        throw new Exception("Данный человек уже зарегистрирован");
                    newPatient.MedCard = new MedCard();
                    db.PersonSet.Add(newPatient);
                    db.SaveChanges();

                    return true;
                }
                catch(ArgumentNullException)
                {
                    MessageBox.Show("Заполните пустые поля");
                    return false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Данные в полях выходят за границы возможных значений");
                    return false;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                    return false;
                }
                
            }
        }
    }
}
/*
            string sqlExpression = "INSERT INTO PersonSet (FullName, Gender) VALUES ('Tom Tommy Tomphson', 'M')";
            using (connection)
            {
                using (MEDDBContainer db = new MEDDBContainer())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                   // int number = command.ExecuteNonQuery();

                    db.PersonSet.Add(new Patient { FullName = "Фёдоров Фёдор Фёдорович" });
                    db.PersonSet.Add(new Patient { FullName = "Иванов Фёдор Фёдорович" });
                    db.SaveChanges();
                }
            }*/
