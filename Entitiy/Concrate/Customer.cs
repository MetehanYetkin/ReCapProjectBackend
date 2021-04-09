using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.Concrate
{
   public class Customer:IEntitiy
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string CustomerFirsName { get; set; }
        public string CustomerLastName { get; set; }

    }
}
