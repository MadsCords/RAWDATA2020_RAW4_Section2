using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServiceLib
{   
    public class Users
    {
        [Key]
        public int? Userid { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; }
        public string Firstname { get; set; } 
        public string Lastname { get; set; }
        public string Birthyear { get; set; }
        public string Salt { get; set; }

    }
}
