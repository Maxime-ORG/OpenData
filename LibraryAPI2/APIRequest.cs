using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI2
{
    public class APIRequest : IAPIRequest
    {
        public String GetLineData()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            WebRequest request = WebRequest.CreateHttp("http://data.mobilites-m.fr/api/linesNear/json?x=5.73119705178461&y=45.184446886268645&dist=300&details=true");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string text = readStream.ReadToEnd();
            Console.WriteLine(text);
            return text;
        }
    }
}
