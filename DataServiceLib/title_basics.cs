using System.ComponentModel.DataAnnotations;


namespace DataServiceLib
{
    public class title_basics
    {
        [Key]
        public string tconst { get; set; }
        public string primarytitle { get; set; } //Skal sættes til column navnet i db
        public string titletype { get; set; } //Skal sættes til column navnet i db  
    }
}
