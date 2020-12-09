
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataServiceLib
{
    public class TitleBasicsList
    {
        [Key]
        public string Tconst { get; set; }
        public string PrimaryTitle { get; set; }
        public IList<string> Genres { get; set; }

    }
}
