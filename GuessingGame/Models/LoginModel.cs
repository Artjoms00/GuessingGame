﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuessingGame.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
    }
}
