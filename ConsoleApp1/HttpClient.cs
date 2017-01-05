using System;
using System.IO;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class HttpClient
    {
        public String SendRequest(String uri)
        {
            WebRequest request = WebRequest.Create(uri);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
           
     

            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}
