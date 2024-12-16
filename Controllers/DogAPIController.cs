using System.Collections.Generic;
using DogAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogAPIController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://dog.ceo/");

            var response = await client.GetAsync("api/breed/terrier/list");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStreamAsync();
                return Ok(result);
            }

            return BadRequest();
        }


        /*
        [HttpPost]
        public async Task<ActionResult<Terrier>> PostTerrier()
        {

        }
         */
    }
}
