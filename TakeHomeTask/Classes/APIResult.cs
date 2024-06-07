using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeTask.Classes
{
    public class APIResult
    {   

        public void DisplayResult(APIResponse response,string mode)
        {
            if (response.ResponseCode == 200 && mode != "xml")
            {
                Console.WriteLine($"ID: {response.ID}");
                Console.WriteLine($"Name: {response.Name}");
                Console.WriteLine($"Coordinate: \n Longitude: {response.Coordinates.Longitude} \n Latitude: {response.Coordinates.Latitude}");
                Console.WriteLine($"Weather: \n ID: {response.Weather[0].ID} \n Main: {response.Weather[0].Main} \n Description: {response.Weather[0].Description} \n Icon: {response.Weather[0].Icon}");
                Console.WriteLine($"Base: {response.Base}");
                Console.WriteLine($"Main: \n Temperature: {response.Main.Temperature} \n Feels Like: {response.Main.FeelsLike} \n Minimum Temperature: {response.Main.TempMin} \n Maximum Temperature: {response.Main.TempMax} \n Pressure: {response.Main.Pressure} \n Humidity: {response.Main.Humidity}");
                Console.WriteLine($"Visibility: {response.Visibility}");
                Console.WriteLine($"Wind: \n Speed: {response.Wind.Speed} \n Degrees: {response.Wind.Degrees} \n Gust: {response.Wind.Gust}");
                Console.WriteLine($"Clouds: \n All: {response.Clouds.All}");
                Console.WriteLine($"Date of Time Calculation: {response.TimeOfDateCalculation}");
                Console.WriteLine($"System: \n Type: {response.System.Type} \n ID: {response.System.ID} \n Country: {response.System.Country} \n Sunrise: {response.System.Sunrise} \n Sunset: {response.System.Sunset}");
                Console.WriteLine($"Time Zone: {response.TimeZone}");
            }else if(response.ResponseCode == 200 && mode == "xml")
            {
                Console.WriteLine($"ID: {response.XMLCurrentWeather.XMLCity.XMLID}");
                Console.WriteLine($"Name: {response.XMLCurrentWeather.XMLCity.XMLName}");
                Console.WriteLine($"Coordinate: \n Longitude: {response.XMLCurrentWeather.XMLCity.XMLCoordinates.XMLLongitude} \n Latitude: {response.XMLCurrentWeather.XMLCity.XMLCoordinates.XMLLatitude}");
                Console.WriteLine($"Time Zone: {response.XMLCurrentWeather.XMLCity.XMLTimezone}");
                Console.WriteLine($"Country: {response.XMLCurrentWeather.XMLCity.XMLCountry} \n Sunrise: {response.XMLCurrentWeather.XMLCity.XMLSun.XMLSunrise} \n Sunset: {response.XMLCurrentWeather.XMLCity.XMLSun.XMLSunset}");
                Console.WriteLine($"Temperature: {response.XMLCurrentWeather.XMLTemperature.XMLTemperatureValue} \n Minimum Temperature: {response.XMLCurrentWeather.XMLTemperature.XMLTempMin} \n Maximum Temperature: {response.XMLCurrentWeather.XMLTemperature.XMLTempMax}");
                Console.WriteLine($"Feels Like: \n Value: {response.XMLCurrentWeather.XMLFeelsLike.XMLFeelsLikeValue} \n Units: {response.XMLCurrentWeather.XMLFeelsLike.XMLFeelsLikeUnit}");
                Console.WriteLine($"Humidity: \n Value: {response.XMLCurrentWeather.XMLHumidity.XMLHumidityValue} \n Units: {response.XMLCurrentWeather.XMLHumidity.XMLHumidityUnit}");
                Console.WriteLine($"Pressure: \n Value: {response.XMLCurrentWeather.XMLPressure.XMLPressureValue} \n Units: {response.XMLCurrentWeather.XMLPressure.XMLPressureUnit}");
                Console.WriteLine($"Wind: \n Speed: \n Value: {response.XMLCurrentWeather.XMLWind.XMLSpeed.XMLSpeedValue} \n Unit: {response.XMLCurrentWeather.XMLWind.XMLSpeed.XMLSpeedUnit} \n Name: {response.XMLCurrentWeather.XMLWind.XMLSpeed.XMLSpeedName} \n Gust: \n Value: {response.XMLCurrentWeather.XMLWind.XMLGusts.XMLGustsValue} \n Direction: \n Value: {response.XMLCurrentWeather.XMLWind.XMLDirection.XMLDirectionValue} \n Code: {response.XMLCurrentWeather.XMLWind.XMLDirection.XMLDirectionCode} \n Name: {response.XMLCurrentWeather.XMLWind.XMLDirection.XMLDirectionName}");
                Console.WriteLine($"Cloud: \n Value: {response.XMLCurrentWeather.XMLClouds.XMLCloudsValue} \n Name: {response.XMLCurrentWeather.XMLClouds.XMLCloudsName}");
                Console.WriteLine($"Visibility: \n Value: {response.XMLCurrentWeather.XMLVisibility.XMLVisibilityValue}");
                Console.WriteLine($"Precipitation: \n Mode: {response.XMLCurrentWeather.XMLPrecipitation.XMLPrecipitationMode}");
                Console.WriteLine($"Weather: \n Number: {response.XMLCurrentWeather.XMLWeather.XMLWeatherNumber} \n Value: {response.XMLCurrentWeather.XMLWeather.XMLWeatherValue} \n Icon: {response.XMLCurrentWeather.XMLWeather.XMLWeatherIcon}");
                Console.WriteLine($"Last Update: {response.XMLCurrentWeather.XMLLastUpdate.XMLLastUpdateValue}");
            }
            else
            {
                Console.WriteLine($"Response Code: {response.ResponseCode}");
                Console.WriteLine($"Response Message: {response.ResponseMessage}");
            }
        }
    }

}
