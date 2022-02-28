using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcces;
using Entitys;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
       
        public User Get(string email,string password)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                return dbContext.TUser.FirstOrDefault(x=>x.Email.Equals(email)&&x.Password.Equals(password));
            }

        }

        // GET api/<UserController>/5
        
    }
}
