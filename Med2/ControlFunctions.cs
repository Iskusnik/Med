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

        /*public static string connectionString = @"Data Source=ISKUSNIK;Initial Catalog=NewMedDB;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        
             using (connection)
            {}*/


        public static bool LoginPasswordCheck(string login, string password, out string mes, out Person pers)
        {
            mes = "";
            pers = null;
            if (login == "" || password == "")
            {
                mes = "Заполните поля";
                return false;
            }
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                string[] personInfo = login.Split('_');
                string[] birthInfo = personInfo[1].Split('.');
                pers = db.PersonSet.Find(personInfo[0].GetHashCode(), new DateTime(int.Parse(birthInfo[2]), int.Parse(birthInfo[1]), int.Parse(birthInfo[0])));
                if (pers == null)
                {
                    mes = "Логин или пароль введены неверно";
                    return false;
                }
                else
                    return true;
            }
        }
        public static bool RegistrationCall(object obj, out string login,  out string password)
        {
            RegForm regForm = (RegForm)obj;
            login = "";
            password = "";
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                Patient newPatient = new Patient();
                try
                {
                    if (regForm.comboBoxGender.Text == "" || regForm.textSurname.Text == "" 
                          || regForm.textName.Text == "" || regForm.textBoxPassword2.Text == ""
                          || regForm.textNation.Text == "" || regForm.textLiveAdress.Text == ""
                          || regForm.textRegAdress.Text == ""  || regForm.comboBoxDocType.Text == "" 
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
                        long docNum = long.Parse(regForm.textDocumentN.Text);
                        string docName = regForm.comboBoxDocType.Text;
                        var doc = from d in db.DocumentsSet where (d.DocumentName == docName && d.DocumentNum == docNum) select d;
                        
                        if (doc.Count() == 0)
                            newPatient.Documents = new Documents { DocumentName = docName, DocumentNum = docNum, Person = newPatient };
                        else
                            throw new Exception("Данные документы уже приписаны к другой персоне");
                    }
                    catch (FormatException)
                    {
                        throw new Exception("В номере документа могут быть только цифры");
                    }
                    catch (Exception a)
                    {
                        throw a;
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

                    login = newPatient.FullName + "_" + newPatient.BirthDate;
                    password = newPatient.Password;

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
