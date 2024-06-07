using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeTask.Classes
{
    public class APIRequest
    {
        #region Field/Properties
        private decimal _latitude;
        private decimal _longitude;
        private string _mode;
        private string _units;
        private string _language;

        public decimal Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        public decimal Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }

        public string Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        public string Units
        {
            get { return _units; }
            set { _units = value; }
        }

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        #endregion
    }
}
