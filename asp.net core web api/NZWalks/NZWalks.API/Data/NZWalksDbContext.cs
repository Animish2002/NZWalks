using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        //Creating a constructor
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions): base(dbContextOptions) 
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //SEED THE DATA FOR difficulties
            //easy , medium, hard
            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("3e26a9e3-b247-4ed1-848b-9a6cbf948854"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("42f72a32-d91d-4fc4-af70-60646e41bf8a"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("d4e8ad2b-ee8d-4371-bcc8-d9ed348ca0a7"),
                    Name = "Hard"
                }
            };

            modelBuilder.Entity<Difficulty>().HasData(difficulties);


            //seed data for regions
            var regions = new List<Region>
            {
new Region
                {
                    Id = Guid.Parse("ea7c7efa-cdc0-4a5d-95f4-6fddf826adda"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("392b1ced-cdb7-4e7c-9405-e0cbd18a3555"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("3a14b412-791b-4427-845a-07e6c5644e63"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("08730daf-3793-4508-8103-7403f2064506"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
            
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}