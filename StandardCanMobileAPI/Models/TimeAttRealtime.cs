﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StandardCanMobileAPI.Models
{
    [Table("TIME_ATT_REALTIME")]
    public partial class TimeAttRealtime
    {
        [Key]
        [Column("TAR_ID")]
        public int TarId { get; set; }
        [Column("tar_date", TypeName = "date")]
        public DateTime? TarDate { get; set; }
        [Column("tar_time", TypeName = "datetime")]
        public DateTime? TarTime { get; set; }
        [Column("tar_ip")]
        [StringLength(15)]
        public string TarIp { get; set; }
        [Column("card_no")]
        [StringLength(15)]
        public string CardNo { get; set; }
        /// <summary>
        /// 1: &#3610;&#3633;&#3605;&#3619;, 2:map
        /// </summary>
        [Column("tar_type")]
        public byte? TarType { get; set; }
        [Column("MN_ID")]
        public int? MnId { get; set; }
        [Column("emp_code")]
        [StringLength(20)]
        public string EmpCode { get; set; }
        [Column("emp_id")]
        public int? EmpId { get; set; }
        [Column("m_lat")]
        [StringLength(50)]
        public string MLat { get; set; }
        [Column("m_long")]
        [StringLength(50)]
        public string MLong { get; set; }
        [Column("tar_status")]
        public short? TarStatus { get; set; }
        /// <summary>
        /// 0: &#3652;&#3617;&#3656;&#3626;&#3656;&#3591;, 1: &#3626;&#3656;&#3591;
        /// </summary>
        [Column("send_status")]
        public short? SendStatus { get; set; }
        [StringLength(300)]
        public string Remark { get; set; }
    }
}