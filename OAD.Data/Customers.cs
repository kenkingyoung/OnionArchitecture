//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OAD.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public string cust_id { get; set; }
        public string cust_name { get; set; }
        public string cust_address { get; set; }
        public string cust_city { get; set; }
        public string cust_state { get; set; }
        public string cust_zip { get; set; }
        public string cust_country { get; set; }
        public string cust_contact { get; set; }
        public string cust_email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
