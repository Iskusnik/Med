//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Med
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoctorRecord
    {
        public string Anamnesis { get; set; }
        public string Diagnosis { get; set; }
        public string HelpType { get; set; }
        public string HelpAmount { get; set; }
        public string Result { get; set; }
        public string Standarts { get; set; }
        public string DoctorInfo { get; set; }
        public System.DateTime Date { get; set; }
        public long DoctorID { get; set; }
    
        public virtual MedCard MedCard { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
