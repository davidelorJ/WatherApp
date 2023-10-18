namespace WatherApp
{
    public class EndPoints
    {
        public static string GetGeoApifyEndPoint(String cityNameos)
        {
            //return $"https://api.geoapify.com/v1/geocode/search?text=Bilbao&format=json&apiKey=e432667586ff4858a6a1d098eb9b52cf";
            return $"https://api.geoapify.com/v1/geocode/search?text={cityNameos}&format=json&apiKey={Config.GeoApifyKey}";
        }


        public static string GetWeatherEndPoint(float lat, float lon)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Europe%2FLondon";
            return url;
        }
    }
}

//https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Europe%2FLondon