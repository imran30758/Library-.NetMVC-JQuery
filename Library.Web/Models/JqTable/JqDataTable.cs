﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Web.Models.JqTable
{
    public class JqDataTable<T>
    {
        public string sEcho { get; set; }
        public int iTotalRecords { get; set; }
        public int iTotalDisplayRecords { get; set; }
        public List<T> aaData { get; set; }
    }
}