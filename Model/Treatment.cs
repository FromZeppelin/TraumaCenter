//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraumaSoftware.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Treatment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Treatment()
        {
            this.Payment = new HashSet<Payment>();
        }
    
        public int Id { get; set; }
        public int Cabinet_Id { get; set; }
        public int Medcard_Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public decimal Price { get; set; }
        public string Comment { get; set; }
    
        public virtual Cabinet Cabinet { get; set; }
        public virtual Medcard Medcard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payment { get; set; }
    }
}