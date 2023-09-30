using Code8.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Chatverse.Application.Common.Interfaces;
    public interface IApplicationDbContext 
    {
    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Interest> Interests { get; set; }
    public DbSet<User> Users { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}

