using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeTask.Classes
{
    public class APIUtils
    {
        #region Methods
        public static HttpResponse HttpWebResponse(string APIUrl)
        {
            HttpResponse response = new HttpResponse();

            try
            {
                HttpWebRequest httpRequest = WebRequest.Create(APIUrl) as HttpWebRequest;
                httpRequest.Method = "GET";
                using (HttpWebResponse resp = (HttpWebResponse)httpRequest.GetResponse())
                {
                        using (StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
                        {
                            response.ResponseBody = reader.ReadToEnd();
                        }
                }
                response.ResponseCode = 200;

            }
            catch (Exception ex) { 
               if (ex.Message == "The remote server returned an error: (401) Unauthorized.")
                {
                    response.ResponseCode = 401;
                }
                else
                {
                    response.ResponseCode = 404;
                }
            }

            return response;
        }
        #endregion
    }
}
