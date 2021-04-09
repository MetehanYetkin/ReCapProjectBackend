using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntitiyFramework
{
   public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapProjectSQLDemoContext>, IBrandDal
    {
      
    }
}
