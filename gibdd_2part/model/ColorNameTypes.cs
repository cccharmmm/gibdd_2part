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
    
    public partial class ColorNameTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ColorNameTypes()
        {
            this.CarColors = new HashSet<CarColors>();
        }
    
        public int id { get; set; }
        public string name_ru { get; set; }
        public string name_en { get; set; }
        public Nullable<int> colorid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarColors> CarColors { get; set; }
        public virtual ColorTypes ColorTypes { get; set; }
    }
}
