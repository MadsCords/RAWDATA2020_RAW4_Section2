using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServiceLib
{
    public class TitleGenre
    {
        [Key]
        public string Tconst { get; set; }
        public string Genre { get; set; }
    }
}
