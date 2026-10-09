using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class Treatment
    {
        public Guid Id { get; set; }
        public Guid DiseaseId { get; set; }
        public string TreatmentType { get; set; } = string.Empty;
        public string MethodName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ApplicationInstructions { get; set; }
        public string? Dosage { get; set; }
        public string? Precautions { get; set; }
        public decimal? EffectivenessRating { get; set; }
        public decimal? CostEstimate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public Disease Disease { get; set; } = null!;

    }
}
