
using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.Concrate
{
   public class Brand:IEntitiy
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
