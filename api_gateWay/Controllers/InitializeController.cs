using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api_gateWay.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InitializeController : ControllerBase
    {
        [HttpGet]
        public string RtnInitialize() {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(5);
            stopwatch.Stop();
            return "Ocelot网关初始化成功！耗时："+stopwatch.ElapsedMilliseconds+"ms";
        }
    }
}
