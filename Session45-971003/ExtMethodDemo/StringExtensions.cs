﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMethodDemo
{
    public static class StringExtensions
    {
        public static int ToInt(this string text)
        {
            return int.Parse(text);
        }
    }
}
