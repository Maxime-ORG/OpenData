using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI2
{
    
    public class APIdeserialize
    {
        private IAPIRequest _APIRequestLine;
        public APIdeserialize()
        {
            _APIRequestLine = new APIRequest();
        }

        public APIdeserialize(IAPIRequest dataLineNear)
        {
            _APIRequestLine = dataLineNear;
        }

        public List<LineNear> GetLines()
        {
            String data = _APIRequestLine.GetLineData();
            List<LineNear> lineNear = JsonConvert.DeserializeObject<List<LineNear>>(data);
            return lineNear;
        }
    }
}
