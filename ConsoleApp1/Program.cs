using System;
using System.IO;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            Spotify spotify = new Spotify(client);

            String artist = Console.ReadLine();
            Artist monstercat = spotify.SearchArtist(artist);

            spotify.GetTopTracks(monstercat);

            Console.ReadLine();
        }
    }
}
