using ConsumingWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ConsumingWebApi.Controllers
{
    public class HomeController : Controller
    {


        string Baseurl = "http://localhost:47674/";

        public async Task<ActionResult> Index()
        {
            List<Data> datas = new List<Data>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("seeds");

                if (res.IsSuccessStatusCode)
                {
                    var dataResponse = res.Content.ReadAsStringAsync().Result;

                    datas = JsonConvert.DeserializeObject<List<Data>>(dataResponse);
                }
                return View(datas);
            }
        }

       
    }
}