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

        [HttpGet(Name = nameof(GetTitles))]
        public IActionResult GetTitles(int page = 0, int pageSize = 10)
        {
            
            //if (Program.CurrentUser == null)
            //{
            //    return Unauthorized();
            //}
            
            //try
            //{
                //var Titles = _dataService.GetTitles(Program.CurrentUser.Userid);
                //var Titles = _dataService.GetTitles(1);
                //return Ok(_mapper.Map<IEnumerable<TitleDto>>(Titles));

                var items = _dataService.GetTitles(page, pageSize);

                var numberOfMovies = _dataService.NumberOfMovies();

                var pages = (int)Math.Ceiling((double)numberOfMovies / pageSize);

                var prev = (string)null;
                if (page > 0)
                {
                    prev = Url.Link(nameof(GetTitles), new { page = page - 1, pageSize });
                }

                var next = (string)null;
                if (page < pages - 1)
                {
                    next = Url.Link(nameof(GetTitles), new { page = page + 1, pageSize });
                }


                var result = new
                {
                    pageSizes = new int[] { 5, 10, 15, 20 },
                    count = numberOfMovies,
                    pages,
                    prev,
                    next,
                    items
                };

                return Ok(result);



            //}
            //catch (ArgumentException)
            //{
            //    return Unauthorized();
            //}
        }
    }
}
