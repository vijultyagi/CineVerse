using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineVerseWeb.Models
{
	public class Movie
	{
        [Key]
		public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        [DisplayName("Release Year")]
        [Range(1800, 2100,ErrorMessage = "Invalid Release Year")]
        public string ReleaseYear { get; set; }

        [Required]
        public string Genre { get; set; }

        public string? Director { get; set; }

        public string? Actors { get; set; }

        public string? ImageUrl { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;

    }
}

