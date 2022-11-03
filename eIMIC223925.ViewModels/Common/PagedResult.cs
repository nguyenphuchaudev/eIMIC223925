﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC223925.ViewModels.Common
{
    public class PagedResult <T>
    {
        public int TotalRecord { set; get; }
        public List<T> Items { set; get; }
    }
}