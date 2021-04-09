using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IDataResult<T>:IResult//Aynı kodları tekrar tekrar yazmamak için aynı zamanda bir IResult olduğunu gösterdik.
    {
        T Data { get; }
    }
}
