using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCovid
{
    public class Countries
    {
        public Spain Spain { get; set; } = null!;
    }

    public class Dates
    {
        public TheCovid19 TheCovid19 { get; set; } = null!;
    }

    public class Info
    {
        public string Date { get; set; } = null!;
        public string Date_Generation { get; set; } = null!;
        public string Yesterday { get; set; } = null!;
    }

    public class Link
    {
        public string Href { get; set; } = null!;
        public string Rel { get; set; } = null!;
        public string Type { get; set; } = null!;
    }

    public class Metadata
    {
        public string By { get; set; } = null!;
        public List<string> Url { get; set; } = null!;
    }

    public class Region
    {
        public string Date { get; set; } = null!;
        public string Id { get; set; } = null!;
        public List<Link> Links { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Name_Es { get; set; } = null!;
        public string Name_It { get; set; } = null!;
        public string Source { get; set; } = null!;
        public List<SubRegion> Sub_Regions { get; set; } = null!;
        public int Today_Confirmed { get; set; }
        public int Today_Deaths { get; set; }
        public int Today_Intensive_Care { get; set; }
        public int Today_New_Confirmed { get; set; }
        public int Today_New_Deaths { get; set; }
        public int Today_New_Intensive_Care { get; set; }
        public int? Today_New_Open_Cases { get; set; }
        public object Today_New_Recovered { get; set; } = null!;
        public int Today_New_Total_Hospitalised_Patients { get; set; }
        public int Today_Open_Cases { get; set; }
        public object Today_Recovered { get; set; } = null!;
        public int Today_Total_Hospitalised_Patients { get; set; }
        public double? Today_Vs_Yesterday_Confirmed { get; set; }
        public double? Today_Vs_Yesterday_Deaths { get; set; }
        public object Today_Vs_Yesterday_Intensive_Care { get; set; } = null!;
        public double? Today_Vs_Yesterday_Open_Cases { get; set; }
        public object Today_Vs_Yesterday_Recovered { get; set; } = null!;
        public object Today_Vs_Yesterday_Total_Hospitalised_Patients { get; set; } = null!;
        public int Yesterday_Confirmed { get; set; }
        public int Yesterday_Deaths { get; set; }
        public int Yesterday_Intensive_Care { get; set; }
        public int Yesterday_OpenCases { get; set; }
        public object Yesterday_Recovered { get; set; } = null!;
        public int Yesterday_Total_Hospitalised_Patients { get; set; }
    }

    public class Root
    {
        public Dates Dates { get; set; } = null!;
        public Metadata Metadata { get; set; } = null!;
        public Total Total { get; set; } = null!;
        public string Updated_At { get; set; } = null!;
    }

    public class Spain
    {
        public string Date { get; set; } = null!;
        public string Id { get; set; } = null!;
        public List<Link> Links { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Name_Es { get; set; } = null!;
        public string Name_It { get; set; } = null!;
        public List<Region> Regions { get; set; } = null!;
        public string Source { get; set; } = null!;
        public int Today_Confirmed { get; set; }
        public int Today_Deaths { get; set; }
        public int Today_Intensive_Care { get; set; }
        public int Today_New_Confirmed { get; set; }
        public int Today_New_Deaths { get; set; }
        public int Today_New_Intensive_Care { get; set; }
        public int Today_New_Open_Cases { get; set; }
        public int Today_New_Recovered { get; set; }
        public int Today_New_Total_Hospitalised_Patients { get; set; }
        public int Today_Open_Cases { get; set; }
        public int Today_Recovered { get; set; }
        public int Today_Total_Hospitalised_Patients { get; set; }
        public double? Today_Vs_Yesterday_Confirmed { get; set; }
        public double? Today_Vs_Yesterday_Deaths { get; set; }
        public object Today_Vs_Yesterday_Intensive_Care { get; set; } = null!;
        public double? Today_Vs_Yesterday_Open_Cases { get; set; }
        public object Today_Vs_Yesterday_Recovered { get; set; } = null!;
        public object Today_Vs_Yesterday_Total_Hospitalised_Patients { get; set; } = null!;
        public int Yesterday_Confirmed { get; set; }
        public int Yesterday_Deaths { get; set; }
        public int Yesterday_Intensive_Care { get; set; }
        public int Yesterday_Open_Cases { get; set; }
        public int Yesterday_Recovered { get; set; }
        public int Yesterday_Total_Hospitalised_Patients { get; set; }
    }

    public class SubRegion
    {
        public string Date { get; set; } = null!;
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Name_Es { get; set; } = null!;
        public string Name_It { get; set; } = null!;
        public string Source { get; set; } = null!;
        public int Today_Confirmed { get; set; }
        public int Today_Deaths { get; set; }
        public int Today_New_Confirmed { get; set; }
        public int Today_New_Deaths { get; set; }
        public int Today_New_Recovered { get; set; }
        public int Today_Recovered { get; set; }
        public double? Today_Vs_Yesterday_Confirmed { get; set; }
        public double? Today_Vs_Yesterday_Deaths { get; set; }
        public double? Today_Vs_Yesterday_Recovered { get; set; }
        public int Yesterday_Confirmed { get; set; }
        public int Yesterday_Deaths { get; set; }
        public int Yesterday_Recovered { get; set; }
        public int? Today_Intensive_Care { get; set; }
        public int? Today_NewIntensive_Care { get; set; }
        public int? Today_New_Total_Hospitalised_Patients { get; set; }
        public int? Today_Total_Hospitalised_Patients { get; set; }
        public double? Today_Vs_Yesterday_Intensive_Care { get; set; }
        public double? Today_Vs_Yesterday_Total_Hospitalised_Patients { get; set; }
        public int? Yesterday_Intensive_Care { get; set; }
        public int? Yesterday_Total_Hospitalised_Patients { get; set; }
    }

    public class TheCovid19
    {
        public Countries Countries { get; set; } = null!;
        public Info Info { get; set; } = null!;
    }

    public class Total
    {
        public string Date { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Name_Es { get; set; } = null!;
        public string Name_It { get; set; } = null!;
        public string Rid { get; set; } = null!;
        public string Source { get; set; } = null!;
        public int Today_Confirmed { get; set; }
        public int Today_Deaths { get; set; }
        public int Today_New_Confirmed { get; set; }
        public int Today_New_Deaths { get; set; }
        public int Today_New_OpenCases { get; set; }
        public int Today_New_Recovered { get; set; }
        public int Today_Open_Cases { get; set; }
        public int Today_Recovered { get; set; }
        public double Today_Vs_Yesterday_Confirmed { get; set; }
        public double Today_Vs_Yesterday_Deaths { get; set; }
        public double Today_Vs_Yesterday_Open_Cases { get; set; }
        public double Today_Vs_Yesterday_Recovered { get; set; }
        public int Yesterday_Confirmed { get; set; }
        public int Yesterday_Deaths { get; set; }
        public int Yesterday_Open_Cases { get; set; }
        public int Yesterday_Recovered { get; set; }
    }
}