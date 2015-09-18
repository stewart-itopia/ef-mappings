namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class KudziContext : DbContext
    {
        public KudziContext()
            : base("name=KudziConnection")
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
