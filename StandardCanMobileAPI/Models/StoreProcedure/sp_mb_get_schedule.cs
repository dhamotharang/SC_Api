﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardCanMobileAPI.Models.StoreProcedure
{
    public class sp_mb_get_schedule
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string title { get; set; }
        public string remark { get; set; }
    }
}
