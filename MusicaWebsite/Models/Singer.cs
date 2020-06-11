using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicaWebsite.Models
{
    public class Singer
    {
        public int SingerId { get; set; }

        public string SingerName { get; set; }

        public string SingerPicture { get; set; }

        public string SingerBiography { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}