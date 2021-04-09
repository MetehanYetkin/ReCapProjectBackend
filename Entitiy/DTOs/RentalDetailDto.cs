using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.DTOs
{
   public class RentalDetailDto:IDto
    {
       
        public string CarName { get; set; }
        public string CustomerFirsName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
