using CommunityToolkit.Mvvm.ComponentModel;
using OpenMeteo;

namespace WpfWeatherApp.ViewModel
{
    /// <summary>
    /// This class is responsible for the weather view model.
    /// </summary>
    internal partial class WeatherViewModel : ObservableObject
    {
        [ObservableProperty]
        Current? currentWeather;

        [ObservableProperty]
        Daily? dailyWeather;

        [ObservableProperty]
        DailyUnits? dailyUnits;

        private readonly OpenMeteoClient client = new OpenMeteoClient();

        public WeatherViewModel()
        {
            UpdateWeather();
        }

        /// <summary>
        /// This method gets the current weather from the Meteo API (Package)
        /// </summary>
        private async void UpdateWeather()
        {
            // Get the current weather
            var result = await client.QueryAsync("Linz");

            if (result != null)
            {
                CurrentWeather = result.Current;
                DailyWeather = result.Daily;
                DailyUnits = result.DailyUnits;
            }
        }

        /*
        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        [ObservableProperty]
        private string? cityName;

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        [ObservableProperty]
        private string? temperature;
        /// <summary>
        /// Gets or sets the weather.
        /// </summary>
        [ObservableProperty]
        private string? weather;

        /// <summary>
        /// Gets or sets the weather icon.
        /// </summary>
		[ObservableProperty]
        private string? weatherIcon;

        /// <summary>
        /// Gets or sets the wind speed.
        /// </summary>
		[ObservableProperty]
        private string? windSpeed;

        /// <summary>
        /// Gets or sets the humidity.
        /// </summary>
		[ObservableProperty]
        private string? humidity;

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
		[ObservableProperty]
        private string? visibility;

        /// <summary>
        /// Gets or sets the sunrise.
        /// </summary>
		[ObservableProperty]
        private string? sunrise;

        /// <summary>
        /// Gets or sets the sunset.
        /// </summary>
		[ObservableProperty]
        private string? sunset;
        */
    }
}
