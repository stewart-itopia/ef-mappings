namespace WebApplication2.Models
{
    public class UserEmail
    {
        public int UserId { get; set; }
        public int EmailId { get; set; }
        public bool IsPrimary { get; set; }
        public virtual  Email   Email { get; set; }
        public virtual User User { get; set; }
    }
}