using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class  ForumPost
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string? Category { get; set; }
        public string[] Images { get; set; } = Array.Empty<string>();
        public int ViewsCount { get; set; } = 0;
        public bool IsPinned { get; set; } = false;
        public bool IsLocked { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public User User { get; set; } = null!;
        public ICollection<ForumReply> Replies { get; set; } = new List<ForumReply>();
    }
}
