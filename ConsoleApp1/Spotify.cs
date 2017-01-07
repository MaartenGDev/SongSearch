using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Spotify
    {
        private HttpClient Client;

        public Spotify(HttpClient client)
        {
            Client = client;
        }

        public Artist SearchArtist(String name)
        {
            String response = Client.SendRequest($"https://api.spotify.com/v1/search?q={name}&type=artist");


            JObject allArtists = JObject.Parse(response);

            JObject currentUser = (JObject) allArtists["artists"]["items"][0];

            String id = (String) currentUser["id"];
            String username = (String) currentUser["name"];
            String uri = (String) currentUser["uri"];
            int totalFollowers = (int) currentUser["followers"]["total"];

            return new Artist(id, username, uri, totalFollowers);

        }

        public Tracks GetTopTracks(Artist artist)
        {
            String ArtistId = artist.Id;
            String response = Client.SendRequest($"https://api.spotify.com/v1/artists/{ArtistId}/top-tracks?country=NL");


            JObject allTracks = JObject.Parse(response);

            IEnumerable<object> trackList = allTracks["tracks"];

            Tracks tracks = new Tracks();

            foreach (JObject trackItem in trackList)
            {
                String name = (String)trackItem["name"];
                String uri = (String)trackItem["uri"];
                String type = (String)trackItem["type"];
                String href = (String)trackItem["href"];
       

                Track track = new Track(name,uri, type, href);
                tracks.AddTrack(track);
            }


            return tracks;
        }
    }
}
