using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicaWebsite.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string AuthorPicture { get; set; }

        public string AuthorBiography { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}