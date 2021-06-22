using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_users.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public List<dynamic> GetUsers()
        {
            var list = new List<dynamic>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new
                {
                    UuerId =Guid.NewGuid(),
                    Name ="tianfx"+i,
                    Age = 40,
                    Sex="男",
                    CreatedTime = DateTime.Now,
                }); ;
            }

            return list;
        }
    }
}
