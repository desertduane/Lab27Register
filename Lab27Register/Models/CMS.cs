﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Register.Models
{
    public class CMS
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Content { get; set; }
        public bool IsReleased { get; set; }
    }
}
