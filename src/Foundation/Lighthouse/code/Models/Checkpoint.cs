﻿using System;

namespace Foundation.Lighthouse.Model
{
    public class Checkpoint
    {
        public DateTime DateTime { get; set; }
        public double Performance { get; set; }
        public double Accessibility { get; set; }
        public double BestPractices { get; set; }
        public double SEO { get; set; }
        public string Data { get; set; }
    }
}