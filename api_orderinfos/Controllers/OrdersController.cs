using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_orderinfos.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public List<dynamic> GetOrders() {  
            var list =new List<dynamic>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new
                {
                    OrderNo = Guid.NewGuid(),
                    Price = (i+1) * 2,
                    Size=40,
                    Color=i==0?"red":i==2?"green":"black",
                    CreatedTime = DateTime.Now,
                }); ;
            }

            return list;
        }
    }
}
