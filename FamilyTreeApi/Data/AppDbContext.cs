using FamilyTreeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyTreeApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserChildren> UserChildren { get; set; }
        public DbSet<UserParents> UserParents { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(u => u.Pin)
                .IsRequired()
                .HasMaxLength(14);

            modelBuilder.Entity<User>()
                .Property(u => u.Fio)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<Role>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<UserChildren>()
                .HasKey(uc => uc.Id);

            modelBuilder.Entity<UserChildren>()
                .Property(uc => uc.Pin)
                .IsRequired()
                .HasMaxLength(14);

            modelBuilder.Entity<UserChildren>()
                .Property(uc => uc.Fio)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<UserParents>()
                .HasKey(up => up.Id);

            modelBuilder.Entity<UserParents>()
                .Property(up => up.PinMother)
                .IsRequired()
                .HasMaxLength(14);

            modelBuilder.Entity<UserParents>()
                .Property(up => up.PinFather)
                .IsRequired()
                .HasMaxLength(14);
        }
    }
}