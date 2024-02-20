using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }
        //Create walk
        //POST: /api/walks
        [HttpPost]
   
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDto addWalkRequestDto)
        {
            if(ModelState.IsValid)
            {
                //Map DTO TO DOMAIN model   
                var walkDomainModel = mapper.Map<Walk>(addWalkRequestDto);

                await walkRepository.CreateAsync(walkDomainModel);


                //map domain modelt to dto
                return Ok(mapper.Map<WalkDto>(walkDomainModel));
            }
            return BadRequest(ModelState);
           
        }

        //GET Walks
        //GET: /api/walks?filterOn = Name& filterQuery = Track & sortBy =  Nmame&isAscending=true
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy, [FromQuery] bool? isAscending,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000) 
        {
            var walksDomainModel = await walkRepository.GetAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true,
                pageNumber, pageSize);

            //map domain  model
            return Ok(mapper.Map<List<WalkDto>>(walksDomainModel));
        }

        //Get Walk By ID
        //GET: /api/Walks/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var walkDomainModel = await walkRepository.GetByIdAsync(id);
            if(walkDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WalkDto>(walkDomainModel));

        }

        //UPDATE Walk by id
        //PUT: /api/Walks/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdateWalkRequestDto updateWalkRequestDto)
        {
            if (ModelState.IsValid)
            {
                //map dto to domain model
                var walkDomainModel = mapper.Map<Walk>(updateWalkRequestDto);

                walkDomainModel = await walkRepository.UpdateAsync(id, walkDomainModel);

                if (walkDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<WalkDto>(walkDomainModel));
            }
            return BadRequest(ModelState);
           

        }

        //Delete Walk by id
        //DELETE: /api/Walks/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deletedWalkDomainModel = await walkRepository.DeleteAsync(id);
            if(deletedWalkDomainModel == null)
            {
                return NotFound();
            }

            //map domain model to dto
            return Ok(mapper.Map<WalkDto>(deletedWalkDomainModel));    

        }

    }
}
