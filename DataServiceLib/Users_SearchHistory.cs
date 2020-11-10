using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServiceLib
{
    public class Users_SearchHistory
    {
        [Key]
        public string Userid { get; set; }
        public string SearchEntry { get; set; }
        public string SearchDate { get; set; }
      
    }
}
