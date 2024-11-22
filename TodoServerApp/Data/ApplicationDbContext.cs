using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<TaskItem> TaskItems { get; set; }
        public virtual DbSet<ProjectItem> ProjectItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure the TaskItem entity
            builder.Entity<TaskItem>()
                .HasOne(t => t.Proj)
                .WithMany()
                .HasForeignKey(t => t.ProjId)
                .OnDelete(DeleteBehavior.SetNull);

            // Seed data for TaskItem
            builder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Title = "������ 1", Description = "�������� ������ 1", CreatedDate = new DateTime(2023, 1, 1) },
                new TaskItem { Id = 2, Title = "������ 2", Description = "�������� ������ 2", CreatedDate = new DateTime(2023, 1, 1) },
                new TaskItem { Id = 3, Title = "������ 3", Description = "�������� ������ 3", CreatedDate = new DateTime(2023, 1, 1) },
                new TaskItem { Id = 4, Title = "������ 4", Description = "�������� ������ 4", CreatedDate = new DateTime(2023, 1, 1) }
            );

            // Seed data for ProjectItem
            builder.Entity<ProjectItem>().HasData(
                new ProjectItem { Id = 1, Title = "������ 1", Description = "�������� ������� 1", CreatedDate = new DateTime(2023, 1, 1) },
                new ProjectItem { Id = 2, Title = "������ 2", Description = "�������� ������� 2", CreatedDate = new DateTime(2023, 1, 1) }
            );
        }
    }
}
