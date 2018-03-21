using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;



using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Med2
{
    public class ControlFunctions
    {


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
                long hash = (long)personInfo[0].GetHashCode();
                DateTime birth = new DateTime(int.Parse(birthInfo[2]), int.Parse(birthInfo[1]), int.Parse(birthInfo[0]));
                pers = db.PersonSet.Find(birth, hash);
                if (pers == null)
                {
                    mes = "Логин или пароль введены неверно";
                    return false;
                }
                else
                    return true;
            }
        }

        public static bool PatientRegistrationCall(object obj, out string login, out string password)
        {
            RegPatForm regForm = (RegPatForm)obj;
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
                          || regForm.textRegAdress.Text == "" || regForm.comboBoxDocType.Text == ""
                          || regForm.textDocumentN.Text == "" || regForm.textBoxPassword1.Text == ""
                          || regForm.textBoxBirthPlace.Text == "")
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
                    newPatient.BirthPlace = regForm.textBoxBirthPlace.Text;
                    newPatient.BloodType = 0;
                    newPatient.Rhesus = "Неизвестно";
                    newPatient.NameHashID = newPatient.FullName.GetHashCode();
                    try
                    {
                        long docNum = long.Parse(regForm.textDocumentN.Text);
                        string docName = regForm.comboBoxDocType.Text;
                        var doc = from d in db.DocumentsSet where (d.DocumentName == docName && d.DocumentNum == docNum) select d;

                        if (docNum < 0)
                            throw new FormatException();

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
                    newPatient.MedCard.Patient = newPatient;
                    db.PersonSet.Add(newPatient);
                    db.SaveChanges();

                    login = newPatient.FullName + "_" + newPatient.BirthDate.ToShortDateString();
                    password = newPatient.Password;

                    return true;
                }
                catch (ArgumentNullException)
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

        public static bool DoctorRegistrationCall(object obj, out string login, out string password)
        {
            RegDocForm regForm = (RegDocForm)obj;
            login = "";
            password = "";
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                Doctor newDoctor = new Doctor();
                try
                {
                    if (regForm.comboBoxGender.Text == "" || regForm.textSurname.Text == ""
                          || regForm.textName.Text == "" || regForm.textBoxPassword2.Text == ""
                          || regForm.textNation.Text == "" || regForm.textLiveAdress.Text == ""
                          || regForm.textRegAdress.Text == "" || regForm.comboBoxDocType.Text == ""
                          || regForm.textDocumentN.Text == "" || regForm.textBoxPassword1.Text == ""
                          || regForm.comboBoxJob.Text == "" || regForm.textBoxEducation.Text == ""
                          || regForm.textBoxBirthPlace.Text == "")
                        throw (new ArgumentNullException());

                    newDoctor.FullName = regForm.textSurname.Text + " " + regForm.textName.Text + " " + regForm.textName2.Text;
                    newDoctor.Gender = regForm.comboBoxGender.Text;
                    newDoctor.BirthDate = regForm.dateTimePickerBirthDate.Value.Date;
                    newDoctor.Nationality = regForm.textNation.Text;
                    newDoctor.LiveAdress = regForm.textLiveAdress.Text;
                    newDoctor.RegAdress = regForm.textRegAdress.Text;
                    newDoctor.RegDate = regForm.dateTimePickerRegDate.Value.Date;
                    newDoctor.InsuranceBillNum = regForm.textBoxInsuranceBillNum.Text;
                    newDoctor.Education = regForm.textBoxEducation.Text;
                    newDoctor.Job = regForm.comboBoxJob.Text;
                    newDoctor.Memberships = regForm.textBoxMemberships.Text;
                    newDoctor.BirthPlace = regForm.textBoxBirthPlace.Text;
                    newDoctor.NameHashID = newDoctor.FullName.GetHashCode();
                    try
                    {
                        long docNum = long.Parse(regForm.textDocumentN.Text);

                        if (docNum < 0)
                            throw new FormatException();

                        string docName = regForm.comboBoxDocType.Text;
                        var doc = from d in db.DocumentsSet where (d.DocumentName == docName && d.DocumentNum == docNum) select d;

                        if (doc.Count() == 0)
                            newDoctor.Documents = new Documents { DocumentName = docName, DocumentNum = docNum, Person = newDoctor };
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
                        newDoctor.Password = regForm.textBoxPassword1.Text;
                    else
                        throw new Exception("Пароль не совпадает с введённым во второй раз");

                    if (db.PersonSet.Find(newDoctor.BirthDate, newDoctor.NameHashID) != null)
                        throw new Exception("Данный человек уже зарегистрирован");



                    newDoctor.FreeTimes = makeJob(new int[] { 0, 1, 2, 3, 4 }, DateTime.Today, newDoctor);
                    newDoctor.WorkTimes = new List<WorkTime>();
                    newDoctor.DoctorRecord = new List<DoctorRecord>();
                    db.PersonSet.Add(newDoctor);
                    db.SaveChanges();

                    login = newDoctor.FullName + "_" + newDoctor.BirthDate.ToShortDateString();
                    password = newDoctor.Password;

                    return true;
                }
                catch (ArgumentNullException)
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

        public static void AnalyseVisits(string fileName)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                object misValue = System.Reflection.Missing.Value;

                // Создаём экземпляр нашего приложения
                Excel.Application excelApp = new Excel.Application();
                // Создаём экземпляр рабочий книги Excel
                Excel.Workbook workBook;
                // Создаём экземпляр листа Excel
                Excel.Worksheet workSheet;

                workBook = excelApp.Workbooks.Add(misValue);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                var specials = (from docs in db.PersonSet where (docs is Doctor) select (docs as Doctor).Job).Distinct().ToArray();
                //var workTime = (from works in db.WorkTimeSet group works by works.Start.Date);
                var workT = (from works in db.WorkTimeSet select new { works.Start, works.Doctor.Job }).ToList();
                //List<DateTime> workDays = new List<DateTime>();
                //foreach (DateTime t in workT)
                //    workDays.Add(t.Date);

                

                DateTime start = (from works in db.WorkTimeSet select works.Start).Min();
                DateTime finish = (from works in db.WorkTimeSet select works.Start).Max();
                int[,] days = new int[specials.Length, (finish.Date - start.Date).Days + 1];


                //Подсчёт прёмов по профессиям и по дням
                for (int i = 0; i < specials.Length; i++)
                    foreach (var t in workT)
                      if (specials[i] == t.Job)
                        days[i, (t.Start.Date - start.Date).Days]++;

                //Заполнение строчек и столбцов посчитанными значениями
                for (int i = 1; i <= specials.Length; i++)
                {
                    workSheet.Cells[i, 1] = specials[i-1];

                    for (int j = 2; j <= days.GetLength(1) + 1; j++)
                        workSheet.Cells[i, j] = days[i-1, j-2];
                }

                workSheet.Cells[specials.Length+1, 1] = start;

                for (int i = 2; i <= days.GetLength(1); i++)
                    workSheet.Cells[specials.Length+1, i] = start.AddDays(1);
                /*
                //Вычисляем сумму этих чисел
                Excel.Range rng = workSheet.Range["A2"];
                rng.Formula = "=SUM(A1:L1)";
                rng.FormulaHidden = false;

                // Выделяем границы у этой ячейки
                Excel.Borders border = rng.Borders;
                border.LineStyle = Excel.XlLineStyle.xlContinuous;
                */

                Excel.ChartObjects xlCharts = (Excel.ChartObjects)workSheet.ChartObjects(Type.Missing);
                Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
               // Excel.ChartObject chartObj = myChart.Add(5, 50, 300, 300);
                Excel.Chart chartPage = myChart.Chart;
                chartPage.ChartType = Excel.XlChartType.xlXYScatterLines;
                Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
                Excel.SeriesCollection seriesCollection = chartPage.SeriesCollection();

                char a = char.ConvertFromUtf32((char.ConvertToUtf32('A',0) + days.GetLength(1)));

                Excel.Range rngX = workSheet.Range["A" + (1+ specials.Length).ToString(), ToString()]
                    workSheet.Cells[specials.Length+1, 1], workSheet.Cells[specials.Length+1, days.GetLength(1)]];

                for (int i = 1; i <= specials.Length; i++)
                {
                    Excel.Series series = seriesCollection.NewSeries();
                    Excel.Range rng = workSheet.Range[workSheet.Cells[i, 2], workSheet.Cells[i, days.GetLength(1)]];
                    series.XValues = workSheet.get_Range(rngX);
                    series.Values = workSheet.get_Range(rng);
                    series.Name = workSheet.Cells[i, 0];
                }

                workBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                workBook.Close(true, misValue, misValue);
                excelApp.Quit();

                /*
                 xlChart.Activate();
                xlChart.Select(Type.Missing);
                
                
                //Даем названия осей
                ((Excel.Axis)excelApp.ActiveChart.Axes(Excel.XlAxisType.xlCategory,
                    Excel.XlAxisGroup.xlPrimary)).HasTitle = true;
                ((Excel.Axis)excelApp.ActiveChart.Axes(Excel.XlAxisType.xlCategory,
                    Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Дата";
                ((Excel.Axis)excelApp.ActiveChart.Axes(Excel.XlAxisType.xlSeriesAxis,
                    Excel.XlAxisGroup.xlPrimary)).HasTitle = false;
                ((Excel.Axis)excelApp.ActiveChart.Axes(Excel.XlAxisType.xlValue,
                    Excel.XlAxisGroup.xlPrimary)).HasTitle = true;
                ((Excel.Axis)excelApp.ActiveChart.Axes(Excel.XlAxisType.xlValue,
                    Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Приёмов";

                excelApp.ActiveChart.HasTitle = true;
                excelApp.ActiveChart.ChartTitle.Text = "Количество приёмов на каждую специальность по дням";

                //Будем отображать легенду 
                excelApp.ActiveChart.HasLegend = true;
                //Расположение легенды
                excelApp.ActiveChart.Legend.Position
                   = Excel.XlLegendPosition.xlLegendPositionLeft;
                   */


                // Открываем созданный excel-файл
                //excelApp.Visible = true;
                //excelApp.UserControl = true;
                
            }
        }


        //График работа на ближайшие 30 дней cчитая  со следующего дня
        //start - час и день начала работы
        //
        static public List<FreeTime> makeJob(int[] week, DateTime start, Doctor doct, int minutes = 5, int hours = 8, int days = 30)
        {
            int N = (int)TimeSpan.FromHours(hours).TotalMinutes / minutes;    //получаем количество приёмов

            List<FreeTime> workTable = new List<FreeTime>();
            
            DateTime startingTime = start;



            for (int day = 1; day <= days; day++)
            {
                startingTime = startingTime.AddDays(1);
                int dayOfWeek = -1;
                if (startingTime.DayOfWeek == DayOfWeek.Monday)
                    dayOfWeek = 0;
                if (startingTime.DayOfWeek == DayOfWeek.Tuesday)
                    dayOfWeek = 1;
                if (startingTime.DayOfWeek == DayOfWeek.Wednesday)
                    dayOfWeek = 2;
                if (startingTime.DayOfWeek == DayOfWeek.Thursday)
                    dayOfWeek = 3;
                if (startingTime.DayOfWeek == DayOfWeek.Friday)
                    dayOfWeek = 4;
                if (startingTime.DayOfWeek == DayOfWeek.Saturday)
                    dayOfWeek = 5;
                if (startingTime.DayOfWeek == DayOfWeek.Sunday)
                    dayOfWeek = 6;

                DateTime timeInDay = startingTime;
                foreach (int d in week)
                {
                    if (d == dayOfWeek)
                        for (int i = 0; i < N; i++)
                        {
                            FreeTime item = new FreeTime();
                            item.Doctor = doct;
                            item.BirthDate = doct.BirthDate;
                            item.NameHashID = doct.NameHashID;
                            item.Start = timeInDay;
                            timeInDay = timeInDay.AddMinutes(minutes);
                            item.Finish = timeInDay;
                            workTable.Add(item);
                        }
                }
            }
            return workTable;
        }
        static public List<FreeTime> makeJob(bool[] weekCheck, DateTime start, Doctor doct, int minutes = 5, int hours = 8, int days = 30)
        {
            
            int count = 0;
            for (int i = 0; i < 7; i++)
                if (weekCheck[i])
                    count++;

            int[] week = new int[count];
            count = 0;

            for (int i = 0; i < 7; i++)
                if (weekCheck[i])
                {
                    week[count] = i;
                    count++;
                }
            int N = (int)TimeSpan.FromHours(hours).TotalMinutes / minutes;    //получаем количество приёмов

            List<FreeTime> workTable = new List<FreeTime>();

            DateTime startingTime = start;



            for (int day = 1; day <= days; day++)
            {
                startingTime = startingTime.AddDays(1);
                int dayOfWeek = -1;
                if (startingTime.DayOfWeek == DayOfWeek.Monday)
                    dayOfWeek = 0;
                if (startingTime.DayOfWeek == DayOfWeek.Tuesday)
                    dayOfWeek = 1;
                if (startingTime.DayOfWeek == DayOfWeek.Wednesday)
                    dayOfWeek = 2;
                if (startingTime.DayOfWeek == DayOfWeek.Thursday)
                    dayOfWeek = 3;
                if (startingTime.DayOfWeek == DayOfWeek.Friday)
                    dayOfWeek = 4;
                if (startingTime.DayOfWeek == DayOfWeek.Saturday)
                    dayOfWeek = 5;
                if (startingTime.DayOfWeek == DayOfWeek.Sunday)
                    dayOfWeek = 6;

                DateTime timeInDay = startingTime;
                foreach (int d in week)
                {
                    if (d == dayOfWeek)
                        for (int i = 0; i < N; i++)
                        {
                            FreeTime item = new FreeTime();
                            item.Doctor = doct;
                            item.Start = timeInDay;
                            item.BirthDate = doct.BirthDate;
                            item.NameHashID = doct.NameHashID;
                            timeInDay = timeInDay.AddMinutes(minutes);
                            item.Finish = timeInDay;
                            workTable.Add(item);
                        }
                }
            }
            return workTable;
        }


        public static void ClearDataBase()
        {
            
            
        }


        static Random random = new Random();
        public static void GenerateRandomDataBase(int N = 50)
        {
            int doctorNum = random.Next(1, N / 5 + 2);
            string[] Vacancies = { "Главврач", "Хирург", "Эндокринолог", "Невролог", "Участковый врач", "Окуляринголог", "Дантист" };
            string[] NamesM = { "Иван", "Денис", "Вячеслав", "Владимир", "Константин", "Александр", "Михаил", "Игнат", "Артём" };
            string[] NamesW = { "Алёна", "Арина", "Елизавета", "Екатерина", "Александра", "Кристина", "Татьяна", "Людмила" };
            string[] Genders = { "Мужской", "Женский" };
            string[] Surnames = { "Иванов", "Александров", "Степанов", "Семёнов", "Удальцов", "Молодцов", "Бобров", "Медведев" };

            string[] BirthPlaces = { "Уфа","Барнаул", "Екатеринбург", "Йошкар-Ола", "Таганрог", "Егоров", "Москва", "Евпатория", "Новороссийск", "Якутск"};
            string[] DocumentTypes = {
                                        "Паспорт гражданина РФ",
                                        "Свидетельство о рождении",
                                        "Дипломатический паспорт",
                                        "Паспорт моряка",
                                        "Военный билет",
                                        "Удостоверение личности военнослужащего",
                                        "Удостоверение беженца",
                                        "Служебное удостоверение работника прокуратуры"
                                    };

            string[] Nationalities = { "Российская Федерация", "Англия", "Бавария", "Российская Федерация" };

            string[] Educations = { "Мед.образование1", "Мед.образование2", "Мед.образование3" };

            for (int i = 0; i < N; i++)
            {
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    Person temp = new Person();
                    temp.BirthPlace = BirthPlaces[random.Next(0, 10)];
                    temp.BirthDate = new DateTime(random.Next(1950, 2018), random.Next(1, 13), random.Next(1, 28));
                    temp.RegDate = new DateTime(random.Next(1950, 2018), random.Next(1, 13), random.Next(1, 28));
                    temp.Documents = new Documents { DocumentName = DocumentTypes[random.Next(0, 8)], DocumentNum = random.Next(0, Int32.MaxValue), Person = temp };
                    if (random.Next(0, 2) == 0)
                    {
                        temp.Gender = Genders[0];
                        temp.FullName = Surnames[random.Next(0, 8)] + " " + NamesM[random.Next(0, 9)] + " " + NamesM[random.Next(0, 9)] + "ович";
                    }
                    else
                    {
                        temp.Gender = Genders[1];
                        temp.FullName = Surnames[random.Next(0, 8)] + "а " + NamesW[random.Next(0, 8)] + " " + NamesM[random.Next(0, 9)] + "овна";
                    }
                    temp.InsuranceBillNum = random.Next(0, Int32.MaxValue).ToString();
                    temp.LiveAdress = random.Next(0, 4).ToString();
                    temp.RegAdress = random.Next(10, 20).ToString();
                    temp.NameHashID = temp.FullName.GetHashCode();

                    if (temp.Documents.DocumentName == "Удостоверение беженца")
                        temp.Nationality = Nationalities[random.Next(1, 4)];
                    else
                        temp.Nationality = Nationalities[0];

                    temp.Password = "1";

                    if (doctorNum > 0)
                    {
                        doctorNum--;

                        Doctor t = new Doctor();
                        (t as Person).BirthDate = temp.BirthDate;
                        (t as Person).Documents = temp.Documents;
                        (t as Person).Documents.Person = t;
                        (t as Person).FullName = temp.FullName;
                        (t as Person).Gender = temp.Gender;
                        (t as Person).InsuranceBillNum = temp.InsuranceBillNum;
                        (t as Person).LiveAdress = temp.LiveAdress;
                        (t as Person).NameHashID = temp.NameHashID;
                        (t as Person).Nationality = temp.Nationality;
                        (t as Person).Password = temp.Password;
                        (t as Person).RegAdress = temp.RegAdress;
                        (t as Person).RegDate = temp.RegDate;
                        (t as Person).BirthPlace = temp.BirthPlace;

                        t.Memberships = "";
                        if (0 == random.Next(0, 6))
                            t.Memberships = "Médecins Sans Frontières";
                        t.Education = Educations[random.Next(0, 3)];
                        t.Job = Vacancies[random.Next(0, 7)];

                        int week = random.Next(0, 4);
                        if (0 == week)
                            t.FreeTimes = makeJob(new int[] { 0, 3, 5 }, DateTime.Today, t, random.Next(3, 8), random.Next(5, 10), random.Next(10, 20));
                        if (1 == week)
                            t.FreeTimes = makeJob(new int[] { 0, 1, 2, 5 }, DateTime.Today, t, random.Next(3, 8), random.Next(5, 10), random.Next(10, 20));
                        if (2 == week)
                            t.FreeTimes = makeJob(new int[] { 0, 1, 2, 3, 4, 5, 6 }, DateTime.Today, t, random.Next(3, 8), random.Next(5, 10), random.Next(10, 20));
                        if (3 == week)
                            t.FreeTimes = makeJob(new int[] { 4 }, DateTime.Today, t, random.Next(3, 8), random.Next(5, 10), random.Next(10, 20));
                        
                        t.WorkTimes = new List<WorkTime>();
                        t.DoctorRecord = new List<DoctorRecord>();
                        db.PersonSet.Add(t);
                        db.SaveChanges();
                    }
                    else
                    {
                        Patient t = new Patient();
                        (t as Person).BirthDate = temp.BirthDate;
                        (t as Person).Documents = temp.Documents;
                        (t as Person).FullName = temp.FullName;
                        (t as Person).Gender = temp.Gender;
                        (t as Person).InsuranceBillNum = temp.InsuranceBillNum;
                        (t as Person).LiveAdress = temp.LiveAdress;
                        (t as Person).NameHashID = temp.NameHashID;
                        (t as Person).Nationality = temp.Nationality;
                        (t as Person).Password = temp.Password;
                        (t as Person).RegAdress = temp.RegAdress;
                        (t as Person).RegDate = temp.RegDate;
                        (t as Person).Documents.Person = t;
                        (t as Person).BirthPlace = temp.BirthPlace;

                        t.BloodType = (byte)random.Next(1, 5);
                        t.Rhesus = "+";
                        if (random.Next(0, 100) < 50)
                            t.Rhesus = "-";
                        t.WorkIncapacityListNum = random.Next(0, int.MaxValue).ToString();
                        t.InsurancePolicyNum = random.Next(0, int.MaxValue).ToString();
                        for (int j = 0; j < random.Next(0, 4); j++)
                        {
                            Illness ill = new Illness{ Name = random.Next(0, 100).ToString()};
                            ill.Hash = ill.Name.GetHashCode();
                            if (db.IllnessSet.Find(ill.Hash) != null)
                                ill = db.IllnessSet.Find(ill.Hash);
                            ill.Patient.Add(t);
                            t.Illness.Add(ill);
                        }
                        t.MedCard = new MedCard();
                        t.MedCard.Patient = t;
                        for (int j = 0; j < random.Next(0, 3); j++)
                        {
                            int r = random.Next(0, db.FreeTimeSet.Count());
                            FreeTime freeTi = db.FreeTimeSet.ToArray()[r];
                            //FreeTime freeTi = db.FreeTimeSet.Local.ToArray()[r];
                            //Doctor tempDoctor = (Doctor)(from docs in db.PersonSet.Local where (docs.BirthDate == freeTi.Doctor.BirthDate && docs.NameHashID == freeTi.Doctor.NameHashID) select docs).ToList()[0];

                            Doctor tempDoctor = (Doctor)db.PersonSet.Find(freeTi.Doctor.BirthDate, freeTi.Doctor.NameHashID);

                            WorkTime workTi = new WorkTime { Start = freeTi.Start, Doctor = tempDoctor, Finish = freeTi.Finish, BirthDate = tempDoctor.BirthDate, NameHashID = tempDoctor.NameHashID};
                            
                            db.FreeTimeSet.Remove(freeTi);
                            
                            workTi.VisitInfo = new VisitInfo
                            {
                                WorkTimes = workTi,
                                DateStart = workTi.Start,
                                DateFinish = workTi.Finish,
                                DoctorID = tempDoctor.NameHashID,
                                Patient = t,
                                PatientBirthDate = t.BirthDate,
                                PatientFullName = t.FullName
                            };
                            t.VisitInfo.Add(workTi.VisitInfo);
                            tempDoctor.WorkTimes.Add(workTi);
                            db.WorkTimeSet.Add(workTi);
                            db.VisitInfoSet.Add(workTi.VisitInfo);
                        }
                        db.PersonSet.Add(t);
                        
                        db.SaveChanges();
                    }

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
//static string connectionString = ConfigurationManager.ConnectionStrings["Med.Properties.Settings.LastMedDBConnectionString"].ConnectionString;
//public static SqlConnection connection = new SqlConnection(connectionString);
//static public LastMedDBDataSet db = new LastMedDBDataSet();
//db.PersonSet_Operator.FindByBirthDateNameHashID()

/*public static string connectionString = @"Data Source=ISKUSNIK;Initial Catalog=NewMedDB;Integrated Security=True";
public static SqlConnection connection = new SqlConnection(connectionString);

     using (connection)
    {}*/

