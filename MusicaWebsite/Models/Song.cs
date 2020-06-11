using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicaWebsite.Models
{
    public class Song
    {
        public int SongId { get; set; }

        public string SongName { get; set; }

        public string Duration { get; set; }

        public string Lyric { get; set; }

        public string SongPath { get; set; }

        public int TimeListen { get; set; }

        public string Picture { get; set; }

        public string DownloadLink { get; set; }

        public DateTime DateCreate { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public int SingerId { get; set; }
        public Singer Singer { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}