﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    public class ThamSo
    {
        public string TenThamSo { get; set; }
        public int GiaTri { get; set; }
        public string FullInfo 
        {
            get
            {
                return $"{TenThamSo} {GiaTri}";
            }
        }
    }
}