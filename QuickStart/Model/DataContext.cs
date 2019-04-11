using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
{
    public class DataContext
    {
        private static List<Artist> artists = null;
        private static List<Artist> topArtists = null;

        protected DataContext()
        {
            
        }

        public static List<Artist> Artists
        {
            get 
            {
                if (artists == null)
                {
                    using (MemoryStream stream = new MemoryStream(Resources.ChinookModel))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        artists = (List<Artist>)formatter.Deserialize(stream);
                    }
                }

                return artists; 
            }
        }

        public static List<Artist> TopArtists
        {
            get
            {
                if (topArtists == null)
                {
                    using (MemoryStream stream = new MemoryStream(Resources.ChinookModel))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        topArtists = (List<Artist>)formatter.Deserialize(stream);

                        while (topArtists.Count > 50)
                        {
                            topArtists.RemoveAt(topArtists.Count - 1);
                        }
                    }
                }

                return topArtists;
            }
        }
    }
}
