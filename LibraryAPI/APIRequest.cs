using System.Net;
using System.Text;

namespace LibraryAPI
{
    public class APIRequest : IAPIRequest
    {
        public String GetLineData()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            WebRequest request = WebRequest.CreateHttp("http://data.mobilites-m.fr/api/linesNear/json?x=5.73119705178461&y=45.184446886268645&dist=500&details=true");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string text = readStream.ReadToEnd();
            return text;
        }
    }
}
