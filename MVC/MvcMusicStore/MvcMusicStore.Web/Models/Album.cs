﻿using System.Collections.Generic;

namespace MvcMusicStore.Web.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}