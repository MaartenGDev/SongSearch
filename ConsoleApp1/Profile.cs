using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Profile
    {
        public String Name;
        public String Uri;
        public int Followers;

        public Profile(String name, String uri, int followers)
        {
            Name = name;
            Uri = uri;
            Followers = followers;
        }
    }
}
