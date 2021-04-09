using Business.Abstract;
using Core.Entities.Concrate;
using Entitiy.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost("Delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        
        [HttpGet("GetUserDetails")]
        public IActionResult GetUserDetails()
        {
            var result = _userService.GetUserDetails();
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result);
        }

        [HttpGet("GetUserDetailsByMail")]
        public IActionResult GetUserDetailsByMail(string mail)
        {
            var result = _userService.GetUserDetailsByMail(mail);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
