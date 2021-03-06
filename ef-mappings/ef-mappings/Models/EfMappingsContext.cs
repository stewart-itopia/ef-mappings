using System.Data.Entity;

namespace ef_mappings.Models
{
    public class EfMappingsContext : DbContext
    {
        public EfMappingsContext()
            : base("name=DefaultConnection")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(q => q.UserId);
            modelBuilder.Entity<Email>().HasKey(q => q.EmailId);

            modelBuilder.Entity<UserEmail>().HasKey(q =>
                new {
                    q.UserId,
                    q.EmailId
                });

            // Relationships
            modelBuilder.Entity<UserEmail>()
                .HasRequired(t => t.Email)
                .WithMany(t => t.UserEmails)
                .HasForeignKey(t => t.EmailId);

            modelBuilder.Entity<UserEmail>()
                .HasRequired(t => t.User)
                .WithMany(t => t.UserEmails)
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<ContractPart>()
            .HasKey(cp => new { cp.ContractId, cp.PartId });

            modelBuilder.Entity<Contract>()
                        .HasMany(c => c.ContractParts)
                        .WithRequired()
                        .HasForeignKey(cp => cp.ContractId);

            modelBuilder.Entity<Part>()
                        .HasMany(p => p.ContractParts)
                        .WithRequired()
                        .HasForeignKey(cp => cp.PartId);
        }
    }
}
