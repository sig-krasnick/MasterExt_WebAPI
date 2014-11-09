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
    
    public partial class staff
    {
        public staff()
        {
            this.payments = new HashSet<payment>();
            this.rentals = new HashSet<rental>();
            this.stores = new HashSet<store>();
        }
    
        public byte staff_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int address_id { get; set; }
        public byte[] picture { get; set; }
        public string email { get; set; }
        public int store_id { get; set; }
        public bool active { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public System.DateTime last_update { get; set; }
    
        public virtual address address { get; set; }
        public virtual ICollection<payment> payments { get; set; }
        public virtual ICollection<rental> rentals { get; set; }
        public virtual store store { get; set; }
        public virtual ICollection<store> stores { get; set; }
    }
}
