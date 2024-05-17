# **Einfache Wetter-App**

## Anforderungen

### Beschreibung

Eine Anwendung, die das aktuelle Wetter für verschiedene Städte anzeigt, indem sie eine Wetter-API verwendet.

### Features

- MVVM Pattern: Wetter-Model, Wetter-View und Wetter-ViewModel.
- Zwei Windows: Hauptfenster (Liste der Städte und aktuelles Wetter) und ein Fenster zum Hinzufügen von Städten.
- ResourceDictionary: Definieren von Styles für Labels, ListViews und Buttons.
- API: Verwendung einer Wetter-API (z.B. OpenWeatherMap) zur Anzeige der Wetterdaten.

### Schritte

- Erstellen des Datenmodells `WeatherInfo`.
- Implementieren des ViewModels für die Hauptansicht und die Detailansicht.
- Gestalten der Views und Binden der Daten.
- Einrichten eines ResourceDictionary für gemeinsame Styles.
- Abrufen von Wetterdaten von einer API.

### Referenzen

API zum Suchen nach der Stadt:
https://geocoding-api.open-meteo.com/v1/search?name=Linz

API zum Suchen nach dem Wetter:
https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,is_day,rain,showers,snowfall,weather_code,cloud_cover,wind_speed_10m,wind_direction_10m&hourly=temperature_2m

NuGet Package:
https://www.nuget.org/packages/OpenMeteo.dotnet
https://github.com/AlienDwarf/open-meteo-dotnet

Country Flags:
https://open-meteo.com/images/country-flags/at.svg

Cloud Icons:
https://www.amcharts.com/free-animated-svg-weather-icons/
