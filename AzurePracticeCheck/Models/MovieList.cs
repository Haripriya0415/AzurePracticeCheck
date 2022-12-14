using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzurePracticeCheck.Models
{
    public class MovieList
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? BoxOffice { get; set; }
        public bool Active { get; set; }
        public DateTime DateOfLaunch { get; set; }
        public bool HasTeaser { get; set; }
        public int GenreId { get; set; }
        public string? GenreType { get; set; }
    }
}
