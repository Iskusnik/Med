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
    
    public partial class Person
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string LiveAdress { get; set; }
        public string RegAdress { get; set; }
        public System.DateTime RegDate { get; set; }
        public string InsuranceBillNum { get; set; }
        public long NameHashID { get; set; }
        public string Password { get; set; }
        public string BirthPlace { get; set; }
    
        public virtual Documents Documents { get; set; }
    }
}
