using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class Disease
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ScientificName { get; set; }
        public string[] AffectedCrops { get; set; }=Array.Empty<string>();
        public string? Description { get; set; }
        public string? Symptoms { get; set; }
        public string? Causes { get; set; }
        public string? PreventionMethods { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
        public ICollection<DiseaseDetection> DiseaseDetections { get; set; } = new List<DiseaseDetection>();
    }
}
