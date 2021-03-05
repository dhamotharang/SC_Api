﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StandardCanMobileAPI.Models
{
    [Table("MAS_CAR_REASON")]
    public partial class MasCarReason
    {
        [Key]
        [Column("MCR_ID")]
        public int McrId { get; set; }
        [Column("MCR_NAME")]
        [StringLength(50)]
        public string McrName { get; set; }
        [Column("MCR_DETAIL")]
        [StringLength(300)]
        public string McrDetail { get; set; }
        [Column("MCR_STATUS")]
        public byte? McrStatus { get; set; }
        [Column("MCR_CREATE_BY")]
        [StringLength(20)]
        public string McrCreateBy { get; set; }
        [Column("MCR_CREATE_DATE", TypeName = "datetime")]
        public DateTime? McrCreateDate { get; set; }
        [Column("MCR_UPDATE_BY")]
        [StringLength(20)]
        public string McrUpdateBy { get; set; }
        [Column("MCR_UPDATE_DATE", TypeName = "datetime")]
        public DateTime? McrUpdateDate { get; set; }
    }
}