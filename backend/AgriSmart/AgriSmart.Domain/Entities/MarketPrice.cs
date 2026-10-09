using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class MarketPrice
    {
        public Guid Id { get; set; }
        public string CropType { get; set; }
        public string? Variety { get; set; }
        public decimal PricePerKg { get; set; }
        public string? MarketName { get; set; }
        public string? MarketLocation { get; set; }
        public decimal? LocationLat { get; set; }
        public decimal? LocationLng { get; set; }
        public string? QualityGrade { get; set; }
        public DateTime RecordedDate { get; set; }
        public string? Source { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
