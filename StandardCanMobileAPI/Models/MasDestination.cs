﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StandardCanMobileAPI.Models
{
    [Table("MAS_DESTINATION")]
    public partial class MasDestination
    {
        [Key]
        [Column("MDT_ID")]
        public int MdtId { get; set; }
        [Column("MDT_NAME")]
        [StringLength(500)]
        public string MdtName { get; set; }
        [Column("MDT_STATUS")]
        public byte? MdtStatus { get; set; }
        [Column("MDT_CREATE_BY")]
        public int? MdtCreateBy { get; set; }
        [Column("MDT_CREATE_DATE", TypeName = "datetime")]
        public DateTime? MdtCreateDate { get; set; }
        [Column("MDT_UPDATE_BY")]
        public int? MdtUpdateBy { get; set; }
        [Column("MDT_UPDATE_DATE", TypeName = "datetime")]
        public DateTime? MdtUpdateDate { get; set; }
    }
}