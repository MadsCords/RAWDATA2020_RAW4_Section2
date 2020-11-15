using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataServiceLib;
using Microsoft.AspNetCore.Mvc;
using WebService.Models;

namespace WebService.Controllers
{
    [ApiController]
    [Route("api/searchtitle")]
    public class FunctionsController : Controller
    {
        IDataService _dataService;
        private readonly IMapper _mapper;

        public FunctionsController(IDataService dataService, IMapper mapper)
        {
            _dataService = dataService;
            _mapper = mapper;
        }
        [HttpGet("{userid}/{searchstring}")]
        public IActionResult SearchTitle(int userid, string searchstring)
        {
           // var stringsearch = "4,Donald%";
            var titlesearch = _dataService.SearchTitle(userid,searchstring);

            return Ok(_mapper.Map<IEnumerable<FunctionsDto>>(titlesearch));
        }

        [HttpGet("structuredsearch/{userid}/{entrytitle}/{entryplot}/{entrycharacters}/{entryname}")]
        public IActionResult StructuredSearch(int userid, string entrytitle, string entryplot, string entrycharacters, string entryname)
        {
            var stringsearch = _dataService.StructuredSearch(userid, entrytitle, entryplot, entrycharacters, entryname);
            return Ok(_mapper.Map<IEnumerable<StructuredSearchDto>>(stringsearch));
        }
    }

}
