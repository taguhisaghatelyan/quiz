//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quiz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_ADMIN
    {
        public TBL_ADMIN()
        {
            this.tbl_categroy = new HashSet<tbl_categroy>();
        }
    
        public int AD_ID { get; set; }
        public string AD_NAME { get; set; }
        public string AD_PASSWORD { get; set; }
    
        public virtual ICollection<tbl_categroy> tbl_categroy { get; set; }
    }
}
