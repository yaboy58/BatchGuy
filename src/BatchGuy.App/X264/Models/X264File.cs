﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.X264.Models
{
    public class X264File
    {
        public int Id { get; set; }
        public string AVSFileNameOnly { get; set; }
        public string AVSFilePath { get; set; }
        public string EncodeName { get; set; }
    }
}