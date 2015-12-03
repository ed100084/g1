using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class SendMessageController : ApiController
    {
        [HttpPost]

        // POST: api/AdCenter

        public async Task<HttpResponseMessage> Post(IEnumerable<Message> messages)
        {
            try
            {
                new ChatHub().SendMessage(messages);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }
    }
}