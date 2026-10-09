using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class ForumReply
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public string[] Images { get; set; } = Array.Empty<string>();
        public bool IsExpertAnswer { get; set; } = false;
        public int Upvotes { get; set; } = 0;
        public int Downvotes { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public ForumPost Post { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
