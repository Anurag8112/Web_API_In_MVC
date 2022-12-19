using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_In_MVC.Controllers
{
    public class ValueController : ApiController
    {
        [Route("api/get")]
        public IHttpActionResult Get()
        {
            return Ok(1);
        }
    }
}
