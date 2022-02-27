using Case.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Repo
{
    public class SeedRepository
    {
        private readonly List<Seed> seeds = new()
        {
            new Seed { Type = "T", Name = "Ekip #44", Mobile = "+90 5xx 11 11", Pernr = "20190026", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.768669, Lng = 30.507332 },

            new Seed { Type = "T", Name = "Ekip #21", Mobile = "+90 5xx 11 11", Pernr = "20200034", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.769669, Lng = 30.507332 },

            new Seed { Type = "T", Name = "Ekip #16", Mobile = "+90 5xx 11 11", Pernr = "20210004", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.790669, Lng = 30.505332 },

            new Seed { Type = "T", Name = "Ekip #35", Mobile = "+90 5xx 11 11", Pernr = "20190094", Dep = "Bakım & Onarım Müdürlüğü", Status = "Raporlu", Lat = 39.792669, Lng = 30.507332 },

            new Seed { Type = "T", Name = "Ekip #71", Mobile = "+90 5xx 11 11", Pernr = "20170019", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.771669, Lng = 30.507332 },

            new Seed { Type = "T", Name = "Ekip #39", Mobile = "+90 5xx 11 11", Pernr = "20100034", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.748669, Lng = 30.507332 },

            new Seed { Type = "T", Name = "Ekip #54", Mobile = "+90 5xx 11 11", Pernr = "20180037", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.749669, Lng = 30.507332 },


            new Seed { Type = "V", Name = "Servis Aracı #35", Mobile = "", Pernr = "V35", LicensePlate = "26 SBA 391", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.767886, Lng = 30.506046 },

            new Seed { Type = "V", Name = "Servis Aracı #47", Mobile = "", Pernr = "V47", LicensePlate = "26 EB 1002", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.773669, Lng = 30.517332 },

            new Seed { Type = "V", Name = "Servis Aracı #84", Mobile = "", Pernr = "V84", LicensePlate = "26 OED 87", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.764858, Lng = 30.502080 },

            new Seed { Type = "V", Name = "Servis Aracı #12", Mobile = "", Pernr = "V12", LicensePlate = "26 SMG 551", Dep = "Bakım & Onarım Müdürlüğü", Status = "Arızalı", Lat = 39.762669, Lng = 30.525332 },

            new Seed { Type = "V", Name = "Servis Aracı #76", Mobile = "", Pernr = "V76", LicensePlate = "26 SVB 77", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.792643, Lng = 30.504737 },

            new Seed { Type = "V", Name = "Servis Aracı #22", Mobile = "", Pernr = "V22", LicensePlate = "26 FRR 631", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.765769, Lng = 30.524332 },

            new Seed { Type = "V", Name = "Servis Aracı #39", Mobile = "", Pernr = "V39", LicensePlate = "26 UC 98", Dep = "Bakım & Onarım Müdürlüğü", Status = "Aktif", Lat = 39.763869, Lng = 30.521332 }
        };

        public IEnumerable<Seed> GetSeeds()
        {
            return seeds;
        }

    }
}
