using ConsumingWebApi.Helpers;
using ConsumingWebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace ConsumingWebApi.Controllers
{
    public class MapsController : Controller
    {

        public ActionResult Index()
        {

            return View();

        }

        public JsonResult GetJson()
        {
            var list = ApiHelper.GetApiDatas();

            return Json(list);
        }
    }
}
