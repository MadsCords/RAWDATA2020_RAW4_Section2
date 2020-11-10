using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebService.Models
{
    public class NameBasicsDto
    {
        [Key]
        public string Nconst { get; set; }
        public string PrimaryName { get; set; }
        public string Birthyear { get; set; }
        public string Deathyear { get; set; }
    }
}