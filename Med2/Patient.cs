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
    
    public partial class Patient : Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Illness = new HashSet<Illness>();
            this.VisitInfo = new HashSet<VisitInfo>();
        }
    
        public string InsurancePolicyNum { get; set; }
        public string WorkIncapacityListNum { get; set; }
        public byte BloodType { get; set; }
        public string Rhesus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Illness> Illness { get; set; }
        public virtual MedCard MedCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitInfo> VisitInfo { get; set; }
    }
}
