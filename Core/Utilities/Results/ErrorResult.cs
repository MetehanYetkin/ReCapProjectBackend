using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)
        {
            //Mesaj gönderebilir.(döndürmek)
        }
        public ErrorResult() :base(false)
        {
           // Hiçbir şey göndermek istemeyebilir (döndürmek)
        }
    }
}
