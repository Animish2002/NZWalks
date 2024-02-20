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
                    Id = Guid.Parse("487ab5d8-4d39-41c3-b64f-62d235307aef"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("d7d6d5bc-ea30-42cf-b94e-7b83640072c4"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("500aff2a-b67d-425e-8656-0b5ed1464c79"),
                    Name = "Hard"
                }
            };

            modelBuilder.Entity<Difficulty>().HasData(difficulties);


            //seed data for regions
            var regions = new List<Region>
            {
new Region
                {
                    Id = Guid.Parse("490df01d-b5c4-46c8-9e92-b47dd30a0481"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("537fa8bf-37bf-4dc3-bdfb-5cc81dc13576"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("fd7cbf6e-f266-4466-8650-ece33d7e7c9f"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("d8d7b43e-2a46-4e35-87a9-95756db213c2"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
            
            };
            var images = new List<Image>
            {
                new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "example.jpg",
                    FileDescription = "Example Image",
                    FileExtension = ".jpg",
                    FileSizeInBytes = 1024, // Example size in bytes
                    FilePath = "path/to/your/image.jpg"
                },
                // Add more images as needed
            };


            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}