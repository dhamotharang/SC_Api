﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardCanMobileAPI.Models.StoreProcedure
{
    public partial class sp_mb_emp_profile
    {
        public string url_img { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string id { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string line { get; set; }
        public string address { get; set; }
        public string dist { get; set; }
        public string prov { get; set; }
        public string country { get; set; }
        public string address_code { get; set; }
        public string outdoor_sts { get; set; }
    }
}