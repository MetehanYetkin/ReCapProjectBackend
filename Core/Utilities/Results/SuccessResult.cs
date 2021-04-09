using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
            //Mesaj bilgisini döndürebilir
        }
        public SuccessResult() : base(true)
        {
            //Hiçbir şey döndürmek istemeyebilir.
        }
    }
}
