using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcces;
using Entitys;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {

        // POST api/<RegisterController>
        [HttpPost]
        public User Post(User user)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                dbContext.TUser.Add(user);
                dbContext.SaveChanges();
                return user;

            }

        }

    }
}
