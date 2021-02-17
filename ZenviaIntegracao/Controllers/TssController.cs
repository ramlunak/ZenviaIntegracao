using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ZenviaIntegracao.Models;

namespace ZenviaIntegracao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TssController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new { init = true });
        }

        [HttpPost]
        public async Task<TSSResponse> Post([FromBody] TSSRequest request)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Access-Token", "75d55d5e3887ab48f574daec509dddbd");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {                   
                    var url = "https://voice-app.zenvia.com/tts";
                    var response = await client.PostAsJsonAsync(url, request);
                    var result = await response.Content.ReadAsStringAsync();
                    var tSSResponse = JsonConvert.DeserializeObject<TSSResponse>(result);
                    return tSSResponse;

                }
                catch (Exception ex)
                {
                    return default(TSSResponse);
                }
            }
        }

    }
}
