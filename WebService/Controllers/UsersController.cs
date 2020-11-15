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
        
        [HttpPost("createuser")]
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
        //[HttpPost("register")]    PROBLEMER MED PACKAGE INSTALLATIONER, KAN IKKE HENTE ELLER UPDATE NYE PACKAGES
        //public IActionResult Register(RegisterDto dto)
        //{
        //    if(_dataService.GetUser(dto.Username) != null)
        //    {
        //        return BadRequest();
        //    }

        //    int pwdSize = 256;

        //    var salt = PasswordService.GenerateSalt(pwdSize);
        //    var pwd = PasswordService.HashPassword(dto.Password, salt, pwdSize);

        //    _dataService.CreateUser(dto.Firstname, dto.Lastname, dto.Username, pwd, salt);

        //    return Ok();
        //}
        //[HttpPost("login")]
        //public IActionResult Login(LoginDto dto)
        //{
        //    var user = _dataService.GetUser(dto.Username);
        //    if(user == null)
        //    {
        //        return BadRequest();
        //    }

        //    int pwdSize = 256;
        //    string secret = "asdsad";

        //    var password = PasswordService.HashPassword(dto.Password, user.Salt, pwdSize);

        //    if(password != user.Password)
        //    {
        //        return BadRequest();
        //    }

        //    var TokenHandler = 

        //    return Ok();
        //}

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