﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StandardCanMobileAPI.Models
{
    [Table("SCHEDULE_COURSE_EMP")]
    public partial class ScheduleCourseEmp
    {
        [Key]
        [Column("SCD_ID")]
        public int ScdId { get; set; }
        [Key]
        [Column("emp_code")]
        [StringLength(20)]
        public string EmpCode { get; set; }
        [Column("score_part_1")]
        public double? ScorePart1 { get; set; }
        [Column("score_part_2")]
        public double? ScorePart2 { get; set; }
        [Column("score_part_3")]
        public double? ScorePart3 { get; set; }
        [Column("score_part_4")]
        public double? ScorePart4 { get; set; }
        [Column("score_part_5")]
        public double? ScorePart5 { get; set; }
        [Column("score_total")]
        public double? ScoreTotal { get; set; }
        [Column("score_result")]
        [StringLength(50)]
        public string ScoreResult { get; set; }
    }
}