using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeTask.Classes
{
    public class HttpResponse
    {
        private int _responseCode;
        private string _responseBody;
        public int ResponseCode
        {
            get { return _responseCode; }
            set { _responseCode = value; }
        }
        public string ResponseBody
        {
            get { return _responseBody; }
            set { _responseBody = value; }
        }
    }

}
