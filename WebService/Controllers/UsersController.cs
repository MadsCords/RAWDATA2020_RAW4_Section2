using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataServiceLib;
using Microsoft.AspNetCore.Mvc;
using WebService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebService.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IDataService _dataService;
        private readonly IMapper _mapper;

        public UsersController(IDataService dataService, IMapper mapper)
        {
            _dataService = dataService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {

            var Users = _dataService.GetUsers();

            return Ok(_mapper.Map<IEnumerable<UsersDto>>(Users));
        }
        //[HttpGet("{id}")]
        //public IActionResult GetUserId(int id)
        //{
        //    var user = _dataService.GetUserId(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(_mapper.Map<UsersDto>(user));
        //}
        [HttpPost]
        public IActionResult CreateUser(UserForCreationDto userCreationDto)
        {
            var user = _mapper.Map<Users>(userCreationDto);

           var newUser =  _dataService.CreateUser(user);

            if(newUser == null)
            {
                return BadRequest();
            }

            return CreatedAtRoute(null, newUser);
        }

        /*[HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, CategoryForCreationOrUpdateDto categoryOrUpdateDto)
        {
            var category = _mapper.Map<Category>(categoryOrUpdateDto);

            if (!_dataService.UpdateCategory(category))
            {
                return NotFound();
            }

            return NoContent();

        }*/
    }
}