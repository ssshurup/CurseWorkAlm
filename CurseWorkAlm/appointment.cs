//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurseWorkAlm
{
    using System;
    using System.Collections.Generic;
    
    public partial class appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public appointment()
        {
            this.review = new HashSet<review>();
        }
    
        public int id { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> serviceId { get; set; }
        public Nullable<int> employeeId { get; set; }
        public Nullable<System.DateTime> dateAppointment { get; set; }
        public Nullable<int> statusId { get; set; }
        public Nullable<int> wayPayId { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual services services { get; set; }
        public virtual status status { get; set; }
        public virtual users users { get; set; }
        public virtual wayPayment wayPayment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<review> review { get; set; }
    }
}
