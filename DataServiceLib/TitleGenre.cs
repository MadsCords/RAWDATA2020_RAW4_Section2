using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServiceLib
{
    public class TitleGenre
    {
        public string Tconst { get; set; }
        public string Genre { get; set; }
        public Title_Basics TitleBasic { get; set; }
    }
}
