using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class Farm
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal? AreaHectares { get; set; }
        public decimal? LocationLat { get; set; }
        public decimal? LocationLng { get; set; }
        public string? Address { get; set; }
        public string? SoilType { get; set; }
        public string? IrrigationType { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public User User { get; set; } = null!;
        public ICollection<Crop> Crops { get; set; } = new List<Crop>();
        public ICollection<DiseaseDetection> DiseaseDetection { get; set; } = new List<DiseaseDetection>();
    }
}
