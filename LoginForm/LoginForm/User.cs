﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class User
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public User(string Fullname,string Email,string Password)
        {
            this.Fullname = Fullname;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
