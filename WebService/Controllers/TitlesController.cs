using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataServiceLib;
using Microsoft.AspNetCore.Mvc;
using WebService.Models;
using WebService.Models.Profiles;

namespace WebService.Controllers
{
    [ApiController]
    [Route("api/Titles")]
    public class TitlesController : ControllerBase
    {
        IDataService _dataService;
        private readonly IMapper _mapper;

        public TitlesController(IDataService dataService, IMapper mapper)
        {
            _dataService = dataService;
            _mapper = mapper;
        }
        
        [HttpGet("{tconst}", Name = nameof(GetTitle))]
        public IActionResult GetTitle(string tconst)
        {
            if (Program.CurrentUser == null)
            {
                return Unauthorized();
            }

            try {
                var Title = _dataService.GetTitle(Program.CurrentUser.Userid, tconst);
                if (Title == null)
                {
                    return NotFound();
                }
                return Ok(_mapper.Map<TitleDto>(Title));
            }
            catch (ArgumentException)
            {
                return Unauthorized();
            }
        }

        [HttpGet]
        public IActionResult GetTitles()
        {
            
            if (Program.CurrentUser == null)
            {
                return Unauthorized();
            }
            
            try
            {
                var Titles = _dataService.GetTitles(Program.CurrentUser.Userid);
                return Ok(_mapper.Map<IEnumerable<TitleDto>>(Titles));
            }
            catch (ArgumentException)
            {
                return Unauthorized();
            }
        }

        //[HttpGet("{id}")]
        //public IActionResult GetCategory(int id)
        //{
        //    var category = _dataService.GetCategory(id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(_mapper.Map<CategoryDto>(category));
        //}

        //[HttpPost]
        //public IActionResult CreateCategory(CategoryForCreationOrUpdateDto categoryOrUpdateDto)
        //{
        //    var category = _mapper.Map<Category>(categoryOrUpdateDto);

        //    _dataService.CreateCategory(category);

        //    return Created("", category);
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateCategory(int id, CategoryForCreationOrUpdateDto categoryOrUpdateDto)
        //{
        //    var category = _mapper.Map<Category>(categoryOrUpdateDto);

        //    if (!_dataService.UpdateCategory(category))
        //    {
        //        return NotFound();
        //    }

        //    return NoContent();

        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteCategory(int id)
        //{
        //    if (!_dataService.DeleteCategory(id))
        //    {
        //        return NotFound();
        //    }

        //    return NoContent();
        //}

        /**
         * 
         *  Dto Helper
         *  
         */
        //private TitleDto CreateTitleDto(Title_Basics title)
        //{
        //    return new TitleDto
        //    {
        //        Url = Url.Link(nameof(GetTitle), new { tconst = title.Tconst}),
        //        TitleType = title.TitleType,
        //        PrimaryTitle = title.PrimaryTitle,
        //        OriginalTitle = title.OriginalTitle,
        //        IsAdult = title.IsAdult,
        //        StartYear = title.StartYear,
        //        EndYear = title.EndYear,
        //        RuntimeMinutes = title.RuntimeMinutes,
        //        Poster = title.Poster,
        //        Awards = title.Awards,
        //        Plot = title.Plot

        //    };
        //}
    }
}
