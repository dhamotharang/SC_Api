//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StandardCan
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOK_CAR
    {
        public int BC_ID { get; set; }
        public string bc_topic { get; set; }
        public Nullable<System.DateTime> bc_start_date { get; set; }
        public string bc_start_time { get; set; }
        public Nullable<System.DateTime> bc_stop_date { get; set; }
        public string bc_stop_time { get; set; }
        public Nullable<int> bc_person_total { get; set; }
        public Nullable<int> MCT_ID { get; set; }
        public Nullable<int> MCA_ID { get; set; }
        public Nullable<int> MCR_ID { get; set; }
        public Nullable<int> MDT_ID { get; set; }
        public string bc_remark { get; set; }
        public string bc_appr_remark { get; set; }
        public Nullable<int> bc_status { get; set; }
        public Nullable<int> bc_create_by { get; set; }
        public Nullable<System.DateTime> bc_create_date { get; set; }
        public Nullable<int> bc_update_by { get; set; }
        public Nullable<System.DateTime> bc_update_date { get; set; }
        public Nullable<int> bc_appr_status { get; set; }
        public Nullable<int> bc_appr_by { get; set; }
        public Nullable<System.DateTime> bc_appr_date { get; set; }
        public Nullable<int> bc_request_by { get; set; }
    }
}
