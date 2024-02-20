using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;
namespace NZWalks.API.Controllers
{

    // https://localhost1234/api/regions
    //it will be pointing to the regions controller

    [Route("api/[controller]")]
    [ApiController]
    
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(NZWalksDbContext dbContext, IRegionRepository regionRepository, IMapper mapper ) 
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }


        // Get all regions
        //GET https://localhost:portNumber/api/regions
        [HttpGet]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetAll()
        {
            //Get data from database - Domain models
            var regionsDomain = await regionRepository.GetAllAsync();



            //Map domain models to dto
            var regionsDto = new List<RegionDto>();
            foreach(var regionDomain in regionsDomain) 
            {
                regionsDto.Add(new RegionDto()
                {
                    Id = regionDomain.Id,
                    Code = regionDomain.Code,
                    Name = regionDomain.Name,
                    RegionImageUrl = regionDomain.RegionImageUrl
                });
            }
            //using automapper
            // var regionDto = mapper.Map<List<RegionDto>>(regionDomain);
            // or
            // return Ok(mapper.Map<List<RegionDto>>(regionDomain));

            //return DTOs
            return Ok(regionsDto); 
        }


        //GET SINGLE REGION (GET REGION BY ID)
        //GET: https://localhost:portnumber/api/regions/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetById([FromRoute] Guid id) 
        {
            //var regionDomain = dbContext.Regions.Find(id);
            //another way 
            var regionDomain = await regionRepository.GetByIdAsync(id);

            if (regionDomain == null) 
            {
                return NotFound();
            }

            //Map/Convert region domain model from database

            var regionDto = new RegionDto
            {
                Id = regionDomain.Id,
                Code = regionDomain.Code,
                Name = regionDomain.Name,
                RegionImageUrl = regionDomain.RegionImageUrl
            };
            //using automapper
            //return Ok(mapper.Map<RegionDto>(regionDomain));

            return Ok(regionDto);
        }


        //Post to Create new Region
        ////GET: https://localhost:portnumber/api/regions
        [HttpPost]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody]AddRegionRequestDto addRegionRequestDto) 
        {
            if(ModelState.IsValid)
            {
                //map or convert dto to domain model
                var regionDomainModel = mapper.Map<Region>(addRegionRequestDto);
                //use domain model to create region
               

                //Map domain model back to dto
                var regionsDto = mapper.Map<RegionDto>(regionDomainModel);
              
                return CreatedAtAction(nameof(GetById), new { id = regionsDto.Id }, regionsDto);

                //using automapper
                //var regionDomainModel = mapper.Map<Region>(addRegionRequestDto);

            }
            else
            {
                return BadRequest(ModelState);
            }

        }


        //Update region
        //PUT: https://localhost:portnumber/api/regions/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            if(ModelState.IsValid)
            {
                
                var regionDomainModel = mapper.Map<Region>(updateRegionRequestDto);

                regionDomainModel = await regionRepository.UpdateAsync(id, regionDomainModel);

                if (regionDomainModel == null)
                {
                    return NotFound();
                }
                return Ok(mapper.Map<Region>(regionDomainModel));

                
            }
            else
            {
                return BadRequest(ModelState);
            }

           
        }


        //Delete region
        //DELETE: https://localhost:portnumber/api/region{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id) 
        {
           var regionDomainModel = await regionRepository.DeleteAsync(id);

            if(regionDomainModel == null)
            {
                return NotFound();  
            }

            

            //return the deleted region back
            //map domain model to dto
            var regionsDto = new RegionDto
            {
                Id = regionDomainModel.Id,
                Code = regionDomainModel.Code,
                Name = regionDomainModel.Name,
                RegionImageUrl = regionDomainModel.RegionImageUrl
            };
           

            return Ok(regionsDto);
        }

    }
}
