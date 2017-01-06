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

        public Profile SearchArtist(String name)
        {
            String response = Client.SendRequest($"https://api.spotify.com/v1/search?q={name}&type=artist");


            JObject allArtists = JObject.Parse(response);

            JObject currentUser = (JObject) allArtists["artists"]["items"][0];

            String username = (String) currentUser["name"];
            String uri = (String) currentUser["uri"];
            int totalFollowers = (int) currentUser["followers"]["total"];

            return new Profile(username, uri, totalFollowers);

        }
    }
}
