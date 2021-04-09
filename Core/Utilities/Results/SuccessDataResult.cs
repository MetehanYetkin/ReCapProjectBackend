using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(string message, T data) : base(message,true, data)
        {
        }
        public SuccessDataResult(string message,bool success):base(message, true,default)
        {

        }
        public SuccessDataResult(T data) : base(data,true)
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
