using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities.Concrate
{
   public class OperationClaim:IEntitiy
    {
        [Key]
        public int ClaimId { get; set; }
        public string Name { get; set; }
    }
}
