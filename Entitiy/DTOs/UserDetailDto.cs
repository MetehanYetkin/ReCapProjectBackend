﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.DTOs
{
   public class UserDetailDto:IDto
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public  string CompanyName { get; set; }
    }
}
