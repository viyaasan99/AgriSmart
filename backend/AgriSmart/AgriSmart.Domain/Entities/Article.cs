using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string? Excerpt { get; set; }
        public string? Category { get; set; }
        public string[] Tags { get; set; } = Array.Empty<string>();
        public string? FeaturedImage { get; set; }
        public Guid AuthorId { get; set; }
        public string Language { get; set; } = "en";
        public int ViewCount { get; set; } = 0;
        public bool IsPublished { get; set; } = true;
        public DateTime? PublishedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public User Author { get; set; } = null!;

    }

}
