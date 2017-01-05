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
            WebRequest request = WebRequest.Create("https://api.spotify.com/v1/search?q=hardwell&type=artist");

            HttpClient client = new HttpClient();
            Spotify spotify = new Spotify(client);


        }
    }
}
