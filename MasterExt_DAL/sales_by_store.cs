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
    
    public partial class sales_by_store
    {
        public int store_id { get; set; }
        public string store { get; set; }
        public string manager { get; set; }
        public Nullable<decimal> total_sales { get; set; }
    }
}