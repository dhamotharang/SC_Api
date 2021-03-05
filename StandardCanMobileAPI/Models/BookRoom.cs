﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StandardCanMobileAPI.Models
{
    [Table("BOOK_ROOM")]
    public partial class BookRoom
    {
        [Key]
        [Column("BR_ID")]
        public int BrId { get; set; }
        [Column("br_topic", TypeName = "text")]
        public string BrTopic { get; set; }
        [Column("br_date", TypeName = "date")]
        public DateTime? BrDate { get; set; }
        [Column("br_start_time")]
        [StringLength(50)]
        public string BrStartTime { get; set; }
        [Column("br_stop_time")]
        [StringLength(50)]
        public string BrStopTime { get; set; }
        [Column("MRM_ID")]
        public int? MrmId { get; set; }
        [Column("br_person_total")]
        public int? BrPersonTotal { get; set; }
        [Column("br_remark", TypeName = "text")]
        public string BrRemark { get; set; }
        [Column("br_appr_remark", TypeName = "text")]
        public string BrApprRemark { get; set; }
        [Column("br_status")]
        public int? BrStatus { get; set; }
        [Column("br_create_by")]
        [StringLength(20)]
        public string BrCreateBy { get; set; }
        [Column("br_create_date", TypeName = "datetime")]
        public DateTime? BrCreateDate { get; set; }
        [Column("br_update_by")]
        [StringLength(20)]
        public string BrUpdateBy { get; set; }
        [Column("br_update_date", TypeName = "datetime")]
        public DateTime? BrUpdateDate { get; set; }
        [Column("br_appr1_status")]
        public int? BrAppr1Status { get; set; }
        [Column("br_appr1_by")]
        [StringLength(20)]
        public string BrAppr1By { get; set; }
        [Column("br_appr1_remark", TypeName = "text")]
        public string BrAppr1Remark { get; set; }
        [Column("br_appr1_date", TypeName = "datetime")]
        public DateTime? BrAppr1Date { get; set; }
        [Column("br_appr2_status")]
        public int? BrAppr2Status { get; set; }
        [Column("br_appr2_by")]
        [StringLength(20)]
        public string BrAppr2By { get; set; }
        [Column("br_appr2_remark", TypeName = "text")]
        public string BrAppr2Remark { get; set; }
        [Column("br_appr2_date", TypeName = "datetime")]
        public DateTime? BrAppr2Date { get; set; }
    }
}