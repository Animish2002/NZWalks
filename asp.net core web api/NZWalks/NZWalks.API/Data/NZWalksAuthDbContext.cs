using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "90fdb8b3-e6fd-4930-be5b-66b3c7126c1d";
            var writerRoleId = "0b8d3cdb-b5f0-4b80-9e0a-b6192ec1f751";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                 Id = readerRoleId,
                 ConcurrencyStamp = readerRoleId,
                 Name = "Reader",
                 NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id= writerRoleId,
                    ConcurrencyStamp= writerRoleId,
                    Name = "Writer",
                    NormalizedName="Writer".ToUpper()
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}