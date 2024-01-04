using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OpenData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMobilite DataMobilite = new DataMobilite();
            DataMobilite.readData(true);
        }
    }
}
