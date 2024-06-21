using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication17.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhatsappController : ControllerBase
    {
        
        // POST api/<WhatsappController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            string token = "TPlDGZ4N6DlHT0VxeD7H1BVAb4ipt2AWqWPREFTSA7wd70y4vklJkL91KrtXVeVgab6sTk0hREFTSAfOjLgmREFTSA26KAc08AyFlCfgxEDwQzAD8DP2267JycjREFTSAyVYMf6dNjnktIU";
            string json;
            string uri = "https://crmwbot.wbot.co.in/api/meta/v19.0/274821605724817/messages/";
            json = "{\"messaging_product\":\"whatsapp\",\"recipient_type\":\"individual\",\"to\":\"919837309990\",\"type\": \"text\",\"text\": {\"preview_url\": false,\"body\": \"text-message-content\"}}";

            HttpClient client =new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token);
            var content = new StringContent(json, Encoding.Default, "application/json");

            HttpResponseMessage hr =  client.PostAsync(uri, content).Result;

           if(hr.IsSuccessStatusCode && Response!=null)
            {
               return Ok();

            }
           else
            {
                return BadRequest();

            }

        }


        
    }
}
