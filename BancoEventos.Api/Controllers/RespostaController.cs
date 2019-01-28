using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BancoEventos.Api.Controllers
{
    [RoutePrefix("api/resposta")]
    public class RespostaController : ApiController
    {
        [Route("obterResposta")]
        public IHttpActionResult Get()
        {
            string data = "ok tudo dar certo";
            return Ok(data);
        }
    }
}
