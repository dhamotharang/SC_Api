﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StandardCanMobileAPI.Models
{
    [Table("CNF_ROOM")]
    public partial class CnfRoom
    {
        [Key]
        [Column("CBR_ID")]
        public int CbrId { get; set; }
        [Column("CBR_AUTO_CANCEL")]
        public double? CbrAutoCancel { get; set; }
    }
}