//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterExt_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventory
    {
        public inventory()
        {
            this.rentals = new HashSet<rental>();
        }
    
        public int inventory_id { get; set; }
        public int film_id { get; set; }
        public int store_id { get; set; }
        public System.DateTime last_update { get; set; }
    
        public virtual film film { get; set; }
        public virtual store store { get; set; }
        public virtual ICollection<rental> rentals { get; set; }
    }
}
