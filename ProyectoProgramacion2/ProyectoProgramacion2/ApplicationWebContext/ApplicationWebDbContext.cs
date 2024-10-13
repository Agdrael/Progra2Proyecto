using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectoProgramacion2.ApplicationWebContext
{
    public class ApplicationWebDbContext : IdentityDbContext
    {
        public ApplicationWebDbContext(DbContextOptions<ApplicationWebDbContext> options)
            : base(options)
        {
            
        }
    }
}
