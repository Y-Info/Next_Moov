using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_moov.Models
{
    public class Result
    {
        public string vote_count { get; set; }
        public string vote_average { get; set; }
        public string title { get; set; }
        public string popularity { get; set; }
        public string poster_path { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        public string backdrop_path { get; set; }
        public string statik = "https://image.tmdb.org/t/p/original";
        public string FullPathPoster => string.Format("{0}{1}", statik, poster_path);
        public string FullPathBG => string.Format("{0}{1}", statik, backdrop_path);
    }

    public class FilmList
    {
        public List<Result> Results { get; set; }
    }
}