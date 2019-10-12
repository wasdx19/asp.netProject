using System;
using System.ComponentModel.DataAnnotations;

namespace asp.netProject.Models.Movies
{
    public class Movie
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Movie name")]
        public string Name { get; set; }
        [Display(Name = "Movie author")]
        public string Author { get; set; }
        [Display(Name = "Movie genre")]
        public string Genre { get; set; }
        [Display(Name = "URL to poster")]
        public string Poster { get; set; }
        [Display(Name = "Release date")]
        public DateTime CreatedAt { get; set; }
    }
}
