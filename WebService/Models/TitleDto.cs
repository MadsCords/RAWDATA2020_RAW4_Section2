using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class TitleDto
    {
        public int tconst { get; set; }
        public string primarytitle { get; set; } //Skal sættes til column navnet i db
        public string titletype { get; set; } //Skal sættes til column navnet i db
    }
}
