﻿using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.DTOs
{
   public class CarDetailDto:IDto
    {
        public int DailyPrice { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; } 
        public string Description { get; set; }
        public short UnitsInStock { get; set; }
        public string ImagePath { get; set; }
        public int CarId { get; set; }

    }
}
