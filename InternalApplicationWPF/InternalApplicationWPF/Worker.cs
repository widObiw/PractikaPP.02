//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternalApplicationWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Worker()
        {
            this.InternalApplication = new HashSet<InternalApplication>();
        }
    
        public int Worker_ID { get; set; }
        public string Worker_Surname { get; set; }
        public string Worker_Name { get; set; }
        public string Worker_Patronymic { get; set; }
        public string Worker_Phone { get; set; }
        public int Post_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternalApplication> InternalApplication { get; set; }
        public virtual Post Post { get; set; }
        public virtual Users Users { get; set; }
    }
}
