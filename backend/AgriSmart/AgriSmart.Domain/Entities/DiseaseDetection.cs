using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class  DiseaseDetection
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? CropId { get; set; }
        public Guid? FarmId { get; set; }
        public Guid? DiseaseId { get; set; }
        public string ImageUrl { get; set; }= string.Empty;
        public decimal ConfidenceScore { get; set; }
        public string? Severity { get; set; }
        public decimal? AffectedAreaPercentage { get; set; }
        public decimal? EstimatedCropLossPercentage { get; set; }
        public DateTime DetectedAt { get; set; } = DateTime.UtcNow;
        public string? UserFeedback { get; set; }
        public string? FeedbackNotes { get; set; }
        public string Status { get; set; } = "Pending"; 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public User User { get; set; }= null!;
        public Crop? Crop { get; set; }
        public Farm? Farm { get; set; }
        public Disease? Disease { get; set; }

    }
}
