using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandWeatherBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:433/{0}";

        public static string Name { get; set; } = "rweather_bot";

        public static string Key { get; set; } = "1425752462:AAESaTsIb7AsDqlvuCLHU0BfzxIZBU9KN4A";
    }
}