﻿using BatchGuy.App.MKVMerge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Models
{
    public class BluRayTitleSubtitle
    {
        public string Id { get; set; }
        public string Language { get; set; }
        public bool IsSelected { get; set; }
        public string Text { get; set; }
        public bool IsCommentary { get; set; }
        public MKVMergeItem MKVMergeItem { get; set; }
        public string ExternalSubtitlePath { get; set; }
        public string ExternalSubtitleNameOnly { get; set; }
    }
}
