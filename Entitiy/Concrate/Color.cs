﻿using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.Concrate
{
   public class Color:IEntitiy
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
