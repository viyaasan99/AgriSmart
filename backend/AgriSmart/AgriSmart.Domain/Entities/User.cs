

namespace AgriSmart.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Role { get; set; } = "farmer";
        public string LanguagePreference { get; set; } = "en";
        public bool IsActive { get; set; } = true;
        public bool EmailVerified { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Farm> Farms { get; set; }= new List<Farm>();
        public ICollection<DiseaseDetection> DiseaseDetections { get; set; } = new List<DiseaseDetection>();
        public ICollectiion<ForumPost> Forumposts { get; set; } = new List<ForumPost>();

    }
}