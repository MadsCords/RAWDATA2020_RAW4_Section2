﻿using System;
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

        [HttpGet]
        public IActionResult GetTitle()
        {
            
            var Titles = _dataService.GetTitles();
            
            return Ok(_mapper.Map<IEnumerable<TitleDto>>(Titles));
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
    }
}
