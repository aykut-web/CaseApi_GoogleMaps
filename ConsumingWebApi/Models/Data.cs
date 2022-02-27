using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumingWebApi.Models
{
    public class Data
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Pernr { get; set; }
        public string LicensePlate { get; set; }
        public string Dep { get; set; }
        public string Status { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}