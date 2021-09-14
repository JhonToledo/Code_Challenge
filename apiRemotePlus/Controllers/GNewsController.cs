using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiRemotePlus.Client;
using apiRemotePlus.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiRemotePlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GNewsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                RequestClient client = new RequestClient();
                GNews news = client.GetNews().GetAwaiter().GetResult();
                return Ok(news);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}