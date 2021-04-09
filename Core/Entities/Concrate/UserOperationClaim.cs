using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrate
{
   public class UserOperationClaim:IEntitiy
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
