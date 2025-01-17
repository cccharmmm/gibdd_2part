//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gibdd_2part.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drivers()
        {
            this.Cars = new HashSet<Cars>();
            this.Fines = new HashSet<Fines>();
            this.Licenses = new HashSet<Licenses>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string middle_name { get; set; }
        public string passport_seria { get; set; }
        public string passport_number { get; set; }
        public string address { get; set; }
        public string address_life { get; set; }
        public Nullable<int> job_id { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string photo { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cars> Cars { get; set; }
        public virtual CompanyJob CompanyJob { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fines> Fines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licenses> Licenses { get; set; }
    }
}
