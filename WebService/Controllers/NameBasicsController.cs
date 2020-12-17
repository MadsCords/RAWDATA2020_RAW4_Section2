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
    [Route("api/Actors")]
    public class NameBasicsController : ControllerBase
    {
        IDataService _dataService;
        private readonly IMapper _mapper;

        public NameBasicsController(IDataService dataService, IMapper mapper)
        {
            _dataService = dataService;
            _mapper = mapper;
        }

        [HttpGet(Name = nameof(GetNames))]
        public IActionResult GetNames(int page = 0, int pageSize = 10)
        {
            var items = _dataService.GetNames(page, pageSize);

            var numberOfActors = _dataService.NumberOfActors();

            var pages = (int)Math.Ceiling((double)numberOfActors/ pageSize);

            var prev = (string)null;
            if (page > 0)
            {
                prev = Url.Link(nameof(GetNames), new { page = page - 1, pageSize });
            }

            var next = (string)null;
            if (page < pages - 1)
            {
                next = Url.Link(nameof(GetNames), new { page = page + 1, pageSize });
            }


            var result = new
            {
                pageSizes = new int[] { 5, 10, 15, 20 },
                count = numberOfActors,
                pages,
                prev,
                next,
                items
            };

            return Ok(result);

        }
    }
}
