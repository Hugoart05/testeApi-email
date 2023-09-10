using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Send.Email.Models;
using Send.Email.Service;

namespace Send.Email.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly SendEmailService _service;
        public EmailController(SendEmailService service)
        {
            _service = service;
        }
        [HttpPost]
        public ActionResult Enviar(EmailModel email)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.EnviaMensagem(email);
                    return Ok();
                }
                catch
                {
                    return BadRequest(ModelState);
                }

            }
            return BadRequest();
        }
    }
}
