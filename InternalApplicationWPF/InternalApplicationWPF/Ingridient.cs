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
    
    public partial class Ingridient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingridient()
        {
            this.ReceiptIngridients = new HashSet<ReceiptIngridients>();
            this.SupplierIngridient = new HashSet<SupplierIngridient>();
        }
    
        public int Ingridient_ID { get; set; }
        public string Ingridient_Name { get; set; }
        public int Unit_ID { get; set; }
    
        public virtual Unit Unit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptIngridients> ReceiptIngridients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierIngridient> SupplierIngridient { get; set; }
    }
}
