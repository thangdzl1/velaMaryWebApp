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
    
    public partial class tb_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_user()
        {
            this.tb_blog = new HashSet<tb_blog>();
            this.tb_cart = new HashSet<tb_cart>();
            this.tb_u_address = new HashSet<tb_u_address>();
        }
    
        public int user_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public Nullable<int> address_id { get; set; }
        public Nullable<int> role_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_blog> tb_blog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cart> tb_cart { get; set; }
        public virtual tb_role tb_role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_u_address> tb_u_address { get; set; }
        public virtual tb_u_address tb_u_address1 { get; set; }
    }
}
