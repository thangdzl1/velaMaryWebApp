//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace velaMaryWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_cart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cart()
        {
            this.tb_product = new HashSet<tb_product>();
        }
    
        public int cart_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public int price { get; set; }
    
        public virtual tb_user tb_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_product> tb_product { get; set; }
    }
}
