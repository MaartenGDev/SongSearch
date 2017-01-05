using System;
using System.Collections.Generic;
using System.Linq;
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


            Console.WriteLine(response);


            return new Profile("Monstercat","example.com", 200);
        }
    }
}
