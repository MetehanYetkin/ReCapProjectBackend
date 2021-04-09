using Core.DataAccess;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IRentalDal: IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetails();
    }
}
