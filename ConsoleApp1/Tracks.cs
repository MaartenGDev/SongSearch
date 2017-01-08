using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tracks : System.Collections.IEnumerable
    {
        private List<Track> tracks = new List<Track>();

        public List<Track> AddTrack(Track track)
        {
            tracks.Add(track);

            return tracks;
        }

        public IEnumerator GetEnumerator()
        {
            return tracks.GetEnumerator();
        }
    }
}
