using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BancoEventos.Api.Controllers
{
    [RoutePrefix("api/quiz")]
    public class QuizController : ApiController
    {
        [Route("ObterQuiz")]
        public  IHttpActionResult Get()
        {
            string data = "ok tudo dar certo";
            return Ok(data);
        }
    }
}
