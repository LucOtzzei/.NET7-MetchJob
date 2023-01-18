﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Otzzei.MetchJob.Domain.Entities;

namespace Otzzei.MetchJob.Infrastructure.Context
{
    public class MetchJobContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public MetchJobContext() { }
        public MetchJobContext(DbContextOptions<MetchJobContext> opts) : base(opts) { }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<JobOpportunity> JobOpportunities { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
