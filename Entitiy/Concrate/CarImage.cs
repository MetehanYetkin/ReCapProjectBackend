using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entitiy.Concrate
{
   public class CarImage:IEntitiy
    { 
        [Key]
        public int ImageId { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime ? ImageDate { get; set; }

    }
}
