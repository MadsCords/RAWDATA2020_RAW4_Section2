using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServiceLib
{
    public class Name_Basics
    {
        [Key]
        public string Nconst { get; set; }
        public string PrimaryName { get; set; }
        public string Birthyear { get; set; }
        public string Deathyear { get; set; }
        

    }
}
