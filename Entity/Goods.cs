﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Serializable]
    public class Goods
    {
        [DataContextAttribute("id")]
        public string id { get; set; }
    }
}