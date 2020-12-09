using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DataServiceLib
{
    public class Title_Basics
    {
        [Key]
        public string Tconst { get; set; }
        public string TitleType { get; set; }
        public string PrimaryTitle { get; set; }
        public string OriginalTitle { get; set; }
        public bool IsAdult { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public int? RuntimeMinutes { get; set; }
        public string Poster { get; set; }
        public string Awards { get; set; }
        public string Plot { get; set; }

        public ICollection<TitleGenre> Genres { get; set; }
    }

}
