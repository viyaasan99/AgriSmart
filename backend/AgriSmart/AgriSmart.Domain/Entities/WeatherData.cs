using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class WeatherData
    {
        public Guid Id { get; set; }
        public decimal LocationLat { get; set; }
        public decimal LocationLng { get; set; }
        public string? LocationName { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal Rainfall { get; set; }
        public decimal? WindSpeed { get; set; }
        public string? WeatherCondition { get; set; }
        public DateTime ForecastDate { get; set; }
        public bool IsForecast { get; set; }
        public DateTime RecordedAt { get; set; } = DateTime.UtcNow;

    }
}
