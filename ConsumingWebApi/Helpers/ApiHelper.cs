using ConsumingWebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ConsumingWebApi.Helpers
{
    public class ApiHelper
    {
        public static IEnumerable<Data> GetApiDatas()
        {
            string Baseurl = "http://localhost:47674/seeds";

            List<Data> datas = new List<Data>();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = client.GetAsync("seeds").Result;
                var dataResponse = res.Content.ReadAsStringAsync().Result;

                datas = JsonConvert.DeserializeObject<List<Data>>(dataResponse);
               
                return datas.AsEnumerable();
            }
        }

    }
}