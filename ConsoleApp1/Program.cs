using System;
using System.Collections.Generic;
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

            Artist artist = spotify.SearchArtist(Console.ReadLine());
            Tracks topTracks = spotify.GetTopTracks(artist);

            Console.WriteLine("Found Artist: " + artist.Name);
            Console.WriteLine("Top Tracks:");

            foreach (Track track in topTracks)
            {
                Console.WriteLine(track);
            }
           
            Console.ReadLine();
        }
    }
}
