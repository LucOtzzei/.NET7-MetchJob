using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Otzzei.MetchJob.Infrastructure.Context
{
    public class MetchJobContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public MetchJobContext(DbContextOptions<MetchJobContext> opts) : base(opts) { }
    }
}
