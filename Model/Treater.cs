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
    
    public partial class Treater
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Treater()
        {
            this.Cabinet = new HashSet<Cabinet>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Birth { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        public int Specification_Id { get; set; }
        public string Education { get; set; }
        public string Career { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cabinet> Cabinet { get; set; }
        public virtual Specification Specification { get; set; }
    }
}