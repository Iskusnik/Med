//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Med2
{
    using System;
    using System.Collections.Generic;
    
    public partial class VisitInfo
    {
        public string PatientFullName { get; set; }
        public System.DateTime PatientBirthDate { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateFinish { get; set; }
        public long DoctorID { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual WorkTime WorkTimes { get; set; }
    }
}
