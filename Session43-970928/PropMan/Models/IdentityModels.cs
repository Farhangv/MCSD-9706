using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PropMan.Models
{

    public class PropManDbContext : IdentityDbContext<ApplicationUser>
    {
        public PropManDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static PropManDbContext Create()
        {
            return new PropManDbContext();
        }

        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Media> Medias { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
    }
}