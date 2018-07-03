﻿using System;
using System.Collections.Generic;

namespace PerfMonitor
{
    public class Metric_List  // class used to aggregate events for transmission via JSON
    {
        public List<CPU_Usage> cpu { get; set; }
        public List<Mem_Usage> mem { get; set; }
        public List<Exceptions> exceptions { get; set; }
        public List<Http_Request> requests { get; set; }
    }
}
