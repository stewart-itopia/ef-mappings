using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class Email
    {
        public int EmailId { get; set; }
        public string Address { get; set; }

        public virtual ICollection<UserEmail> UserEmails { get; set; }
    }
}