using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebService.Models
{
    public class SearchHistoryDto
    {
        [Key]
        public string Userid { get; set; }
        public string SearchEntry { get; set; }
        public string SearchDate { get; set; }

    }
}
