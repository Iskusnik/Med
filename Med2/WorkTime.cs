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
    
    public partial class WorkTime
    {
        public System.DateTime Start { get; set; }
        public System.DateTime Finish { get; set; }
        public long DoctorID { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual VisitInfo VisitInfo { get; set; }
    }
}
