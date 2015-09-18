using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<UserEmail> UserEmails { get; set; }
    }
}