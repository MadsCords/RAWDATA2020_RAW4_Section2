using DataServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class FunctionsDto
    {
        public string Tconst { get; set; }
        public string PrimaryTitle { get; set; }
    }
    
    public class StructuredSearchDto
    {
        public string UserId { get; set; }
        public string EntryTitle { get; set; }
        public string EntryPlot { get; set; }
        public string EntryCharacters { get; set; }
        public string EntryName { get; set; }
    }
}
