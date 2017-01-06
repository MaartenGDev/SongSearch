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



            String username = (String) allArtists["artists"]["items"][0]["name"];
            String uri = (String) allArtists["artists"]["items"][0]["uri"];
            int totalFollowers = (int) allArtists["artists"]["items"][0]["followers"]["total"];

            return new Profile(username, uri, totalFollowers);

        }
    }
}
