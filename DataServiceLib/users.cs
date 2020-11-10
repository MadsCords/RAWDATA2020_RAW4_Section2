using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServiceLib
{   
    public class Users
    {
        [Key]
        public int Userid { get; set; }
        public string username { get; set; } 
        public string firstname { get; set; } 
        public string lastname { get; set; } 
    }
}
