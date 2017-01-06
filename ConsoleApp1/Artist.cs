using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Artist
    {
        public String Id;
        public String Name;
        public String Uri;
        public int Followers;

        public Artist(String id, String name, String uri, int followers)
        {
            Id = id;
            Name = name;
            Uri = uri;
            Followers = followers;
        }

        public override string ToString()
        {
            return $"Name: {Name} has {Followers} followers and his uri is: {Uri}";
        }
    }
}
