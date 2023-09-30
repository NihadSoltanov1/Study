using Azure.Core;
using Chatverse.Application.Common.Interfaces;
using Code8.Application.Common.Interfaces;
using Code8.Domain.Entities;
using Code8.Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Code8.Infrastructure.Persistance
{
    public class AppDbContext : IdentityDbContext<Admin>, IApplicationDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
       

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<User> Users { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasOne(e => e.Education).WithOne(e => e.User).HasForeignKey<Education>(e => e.UserId).IsRequired();
        }
    }

}
