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
    
    public partial class HistoryOfStatus
    {
        public int id { get; set; }
        public string date_of_change { get; set; }
        public string comment { get; set; }
        public int status_id { get; set; }
        public int license_id { get; set; }
    
        public virtual Licenses Licenses { get; set; }
        public virtual StateOfLicenses StateOfLicenses { get; set; }
    }
}
