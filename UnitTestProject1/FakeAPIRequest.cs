using LibraryAPI2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    internal class FakeAPIRequest : IAPIRequest
    {
        public String GetLineData()
        {
            String text = "[{\"id\":\"test\",\"name\":\"test\",\"lon\":0.0,\"lat\":0.0,\"zone\":\"test\",\"lines\":[\"test\"]}]";
            return text;
        }
    }
}
