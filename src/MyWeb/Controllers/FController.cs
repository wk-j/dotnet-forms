using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class FController : ControllerBase {

        [HttpPost]
        public async Task<IActionResult> Upload() {
            var form = await Request.ReadFormAsync();
            foreach (var file in form.Files) {
                Console.WriteLine($"{file.FileName}:{file.ContentType}");
            }

            foreach (var item in form) {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            return Ok();
        }
    }
}