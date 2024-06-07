using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Net;

namespace TakeHomeTask.Classes
{
    #region Json Field/Properties
    public class Coordinates
    {
        [JsonProperty(PropertyName = "lon")]
        public decimal Longitude { get; set; }
        [JsonProperty(PropertyName = "lat")]
        public decimal Latitude { get; set; }
    }
    public class Weather
    {
        public int ID { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Main
    {
       [JsonProperty(PropertyName = "temp")]
        public decimal Temperature { get; set; }
        [JsonProperty(PropertyName = "feels_like")]
        public decimal FeelsLike { get; set; }
        [JsonProperty(PropertyName = "temp_min")]
        public decimal TempMin { get; set; }
        [JsonProperty(PropertyName = "temp_max")]
        public decimal TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }


    public class Wind
    {
        [JsonProperty(PropertyName = "speed")]
        public decimal Speed { get; set; }
        [JsonProperty(PropertyName = "deg")]
        public decimal Degrees { get; set; }
        [JsonProperty(PropertyName = "gust")]
        public decimal Gust { get; set; }
    }

    public class Clouds
    {
        [JsonProperty(PropertyName = "all")]
        public int All { get; set; }
     
    }

    public class System
    {
        [JsonProperty(PropertyName = "sys")]
        public int Type { get; set; }
        public int ID { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }

    }

    #endregion

    #region Xml Field/Properties
    [XmlRoot("current")]
    public class XMLCurrentWeather
    {
        [XmlElement("city")]
        public XMLCity XMLCity { get; set; }

        [XmlElement("temperature")]
        public XMLTemperature XMLTemperature { get; set; }


        [XmlElement("feels_like")]
        public XMLFeelsLike XMLFeelsLike { get; set; }

        [XmlElement("humidity")]
        public XMLHumidity XMLHumidity { get; set; }

        [XmlElement("pressure")]
        public XMLPressure XMLPressure { get; set; }


        [XmlElement("wind")]
        public XMLWind XMLWind { get; set; }


        [XmlElement("clouds")]
        public XMLClouds XMLClouds { get; set; }

        [XmlElement("visibility")]
        public XMLVisibility XMLVisibility { get; set; }

        [XmlElement("precipitation")]
        public XMLPrecipitation XMLPrecipitation { get; set; }


        [XmlElement("weather")]
        public XMLWeather XMLWeather { get; set; }

        [XmlElement("lastupdate")]
        public XMLLastUpdate XMLLastUpdate { get; set; }


    }
    public class XMLCity
    {
        [XmlAttribute("id")]
        public int XMLID { get; set; }

        [XmlAttribute("name")]
        public string XMLName { get; set; }

        [XmlElement("coord")]
        public XMLCoordinates XMLCoordinates { get; set; }

        [XmlElement("country")]
        public string XMLCountry { get; set; }

        [XmlElement("timezone")]
        public int XMLTimezone { get; set; }

        [XmlElement("sun")]
        public XMLSun XMLSun { get; set; }
    }

    public class XMLCoordinates
    {
        [XmlAttribute("lon")]
        public decimal XMLLongitude { get; set; }

        [XmlAttribute("lat")]
        public decimal XMLLatitude { get; set; }
    }

    public class XMLSun
    {
        [XmlAttribute("rise")]
        public string XMLSunrise { get; set; }

        [XmlAttribute("set")]
        public string XMLSunset { get; set; }
    }

    public class XMLTemperature
    {
        [XmlAttribute("value")]
        public decimal XMLTemperatureValue { get; set; }

        [XmlAttribute("min")]
        public decimal XMLTempMin { get; set; }
        [XmlAttribute("max")]
        public decimal XMLTempMax { get; set; }
        [XmlAttribute("unit")]
        public string XMLTempUnit { get; set; }
    }

    public class XMLFeelsLike
    {
        [XmlAttribute("value")]
        public decimal XMLFeelsLikeValue { get; set; }

        [XmlAttribute("unit")]
        public string XMLFeelsLikeUnit { get; set; }
    }

    public class XMLHumidity
    {
        [XmlAttribute("value")]
        public decimal XMLHumidityValue { get; set; }

        [XmlAttribute("unit")]
        public string XMLHumidityUnit { get; set; }
    }


    public class XMLPressure
    {
        [XmlAttribute("value")]
        public decimal XMLPressureValue { get; set; }

        [XmlAttribute("unit")]
        public string XMLPressureUnit { get; set; }
    }

    public class XMLWind
    {
        [XmlElement("speed")]
        public XMLSpeed XMLSpeed { get; set; }

        [XmlElement("gusts")]
        public XMLGusts XMLGusts { get; set; }

        [XmlElement("direction")]
        public XMLDirection XMLDirection { get; set; }
    }

    public class XMLSpeed
    {
        [XmlAttribute("value")]
        public decimal XMLSpeedValue { get; set; }

        [XmlAttribute("unit")]
        public string XMLSpeedUnit { get; set; }

        [XmlAttribute("name")]
        public string XMLSpeedName { get; set; }
    }

    public class XMLGusts
    {
        [XmlAttribute("value")]
        public int XMLGustsValue { get; set; }
    }

    public class XMLDirection
    {
        [XmlAttribute("value")]
        public int XMLDirectionValue { get; set; }

        [XmlAttribute("code")]
        public string XMLDirectionCode { get; set; }

        [XmlAttribute("name")]
        public string XMLDirectionName { get; set; }
    }

    public class XMLClouds
    {
        [XmlAttribute("value")]
        public int XMLCloudsValue { get; set; }

        [XmlAttribute("name")]
        public string XMLCloudsName { get; set; }
    }

    public class XMLVisibility
    {
        [XmlAttribute("value")]
        public int XMLVisibilityValue { get; set; }
    }

    public class XMLPrecipitation
    {
        [XmlAttribute("mode")]
        public string XMLPrecipitationMode { get; set; }

    }

    public class XMLWeather
    {
        [XmlAttribute("number")]
        public int XMLWeatherNumber { get; set; }
        [XmlAttribute("value")]
        public string XMLWeatherValue { get; set; }
        [XmlAttribute("icon")]
        public string XMLWeatherIcon { get; set; }

    }

    public class XMLLastUpdate
    {
        [XmlAttribute("value")]
        public string XMLLastUpdateValue { get; set; }
    }
    #endregion

    public class APIResponse
    {
        #region JSON Field/Properties
        private string _base;
        private int _visibility;
        private int _dt;
        private int _timezone;
        private int _id;
        private string _name;
        private int _responseCode;
        private string _responseMessage;

        [JsonProperty(PropertyName = "coord")]
        public Coordinates Coordinates
        {
            get; set;
        }

        [JsonProperty(PropertyName = "weather")]
        public Weather[] Weather { get; set; }

        
        [JsonProperty(PropertyName = "base")]
        public string Base
        {
            get { return _base; }
            set { _base = value; }
        }

        [JsonProperty(PropertyName = "main")]
        public Main Main
        {
            get; set;
        }

        [JsonProperty(PropertyName = "visibility")]
        public int Visibility
        {
            get { return _visibility; }
            set { _visibility = value; }
        }


        [JsonProperty(PropertyName = "wind")]
        public Wind Wind
        {
            get; set;
        }

        [JsonProperty(PropertyName = "clouds")]
        public Clouds Clouds
        {
            get; set;
        }

        [JsonProperty(PropertyName = "dt")]
        public int TimeOfDateCalculation
        {
            get { return _dt; }
            set { _dt = value; }
        }

        [JsonProperty(PropertyName = "sys")]
        public System System
        {
            get; set;
        }

        [JsonProperty(PropertyName = "timezone")]
        public int TimeZone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }

        [JsonProperty(PropertyName = "id")]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [JsonProperty(PropertyName = "cod")]
        public int ResponseCode
        {
            get { return _responseCode; }
            set { _responseCode = value; }
        }

        [JsonProperty(PropertyName = "message")]
        public string ResponseMessage
        {
            get { return _responseMessage; }
            set { _responseMessage = value; }
        }
        #endregion

        #region XML Properties
        public XMLCurrentWeather XMLCurrentWeather { get; set; }
        #endregion
        internal static APIResponse ParseResponse(HttpResponse httpResponse)
        {
            APIResponse response = new APIResponse();
            try
            {
                if (httpResponse.ResponseCode == 200)
                {
                    if ((httpResponse.ResponseBody.StartsWith("{") && httpResponse.ResponseBody.EndsWith("}")) ||
                        (httpResponse.ResponseBody.StartsWith("[") && httpResponse.ResponseBody.EndsWith("]")))
                    {
                        response = JsonConvert.DeserializeObject<APIResponse>(httpResponse.ResponseBody);
                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(XMLCurrentWeather));
                        using (StringReader reader = new StringReader(httpResponse.ResponseBody))
                        {
                            response.XMLCurrentWeather = (XMLCurrentWeather)serializer.Deserialize(reader);
                        }
                        response.ResponseCode = 200;
                    }
                }
                else if(httpResponse.ResponseCode == 404)
                {
                    response.ResponseCode = 404;
                    response.ResponseMessage = "City not found";
                }
                else if (httpResponse.ResponseCode == 401)
                {
                    response.ResponseCode = 401;
                    response.ResponseMessage = "Invalid API key";
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());    
            }
            return response;
        }
    }
}
