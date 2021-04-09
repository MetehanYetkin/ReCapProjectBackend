using Business.Abstract;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class PaymentManager : IPaymentService
    {
        public IResult Pay()
        {
            var test = new Random().Next(2);
            if(test != 1)
            {
                return new ErrorResult("Ödeme Geçersiz");
            }
            else
            {
                return new SuccessResult("Ödeme Başarılı");
            }
        }
    }
}
