using Newtonsoft.Json;
using System.Text;

/// <summary>
/// OpenWeatherMap API
/// for more detail https://openweathermap.org/api
/// </summary>

public class OpenWeatherMap
{

    //------------------------------------------
    private static string OWMRestApiURL = "https://api.openweathermap.org/data/2.5/";
    private static string OWMRestApiKey = "your_api_key";
    //------------------------------------------
    private static string Latitude = "41.0393954";
    private static string Longitude = "28.9941087";
    private static string City = "Istanbul";
    //------------------------------------------

    public OWMRootObjects.Call5Day3Hour Call5Day3Hour()
    {
        //------------------------------------------
        string URL = OWMRestApiURL + "forecast?lat=" + Latitude + "&lon=" + Longitude + "&appid=" + OWMRestApiKey + "&lang=tr";
        //------------------------------------------
        using (var webClient = new System.Net.WebClient())
        {
            webClient.Encoding = Encoding.UTF8;
            var json = Encoding.UTF8.GetString(webClient.DownloadData(URL));
            OWMRootObjects.Call5Day3Hour items = JsonConvert.DeserializeObject<OWMRootObjects.Call5Day3Hour>(json);
            return items;
        }
    }
    //------------------- Call5Day3Hour ------------------------

    public OWMRootObjects.CurrentWeatherData CurrentWeatherData()
    {
        //------------------------------------------
        string URL = OWMRestApiURL + "weather?lat=" + Latitude + "&lon=" + Longitude + "&appid=" + OWMRestApiKey + "&lang=tr";
        //------------------------------------------
        using (var webClient = new System.Net.WebClient())
        {
            webClient.Encoding = Encoding.UTF8;
            var json = Encoding.UTF8.GetString(webClient.DownloadData(URL));
            OWMRootObjects.CurrentWeatherData items = JsonConvert.DeserializeObject<OWMRootObjects.CurrentWeatherData>(json);
            return items;
        }
    }
    //------------------- CurrentWeatherData ------------------------


}
