using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using LibraryAPI2;

namespace OpenData
{
    public class DataMobilite
    {
        

        public void readData(Boolean isOnline)
        {
            APIdeserialize aPIdeserialize = new APIdeserialize();

            if (!isOnline)
            {
                APIOfflineRequest aPIOfflineRequest = new APIOfflineRequest();
                aPIdeserialize = new APIdeserialize(aPIOfflineRequest);
            } 
            

            List< LibraryAPI2.LineNear > lineNear = aPIdeserialize.GetLines();

            for (int i = 0; i < lineNear.Count; i++)
            {
                Console.WriteLine(lineNear[i].name);
                for (int j = 0; j < lineNear[i].lines.Count; j++)
                {
                    Console.WriteLine(lineNear[i].lines[j]);
                }
            }

            Console.WriteLine("Response stream received.");
        }
    }
}
