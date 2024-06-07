using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace TakeHomeTask.Classes
{
    internal class APIConfiguration
    {
        public static string APIKey
        {
            get
            {
                return (ConfigurationManager.AppSettings["AppID"].ToString() != string.Empty ?
                 ConfigurationManager.AppSettings["AppID"].ToString() : string.Empty);
            }
        }

        public static string APIURL
        {
            get
            {
                return (ConfigurationManager.AppSettings["BaseURL"].ToString() != string.Empty ?
                 ConfigurationManager.AppSettings["BaseURL"].ToString() : string.Empty);
            }
        }
    }
}
