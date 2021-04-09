using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntitiyFramework
{
  public class EfCarImageDal:EfEntityRepositoryBase<CarImage,ReCapProjectSQLDemoContext>,ICarImageDal
    {

    }
}
