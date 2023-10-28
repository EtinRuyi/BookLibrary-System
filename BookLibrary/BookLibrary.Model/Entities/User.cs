using BookLibrary.Model.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace BookLibrary.Model.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
        public bool IsDreprecated { get; set; }
        public Gender Sex { get; set; }
        public EmploymentStatus Employment { get; set; }
    }
}
