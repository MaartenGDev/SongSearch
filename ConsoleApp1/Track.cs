using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Track
    {
        public String Name;
        public String Uri;
        public String Type;
        public String Href;

        public Track(String name, String uri, String type, String href)
        {
            Name = name;
            Uri = uri;
            Type = type;
            Href = href;
        }

        public override string ToString()
        {
            return $"Name: {Name}, uri: {Uri}, with id {Uri}";
        }

    }
}
