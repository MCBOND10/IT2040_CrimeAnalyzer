using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrimeAnalyzer
{
    public static class ReportGetStat
    {
        private static int columns = 11;

        public static List<ReportStat> Load(string dpath)
        {
            List<ReportStat> ras = new List<ReportStat>();

            using (var receive = new StreamReader(dpath))
            {
                int lnum = 0;
                while(!receive.EndOfStream)
                {
                    var line = receive.ReadLine();
                    lnum++;
                    if(lnum == 1)
                    {
                        continue;
                    }
                    var stats = line.Split(',');

                    int year = Int32.Parse(stats[0]);
                    int population = Int32.Parse(stats[1]);
                    int violentcrime = Int32.Parse(stats[2]);
                    int murder = Int32.Parse(stats[3]);
                    int rape = Int32.Parse(stats[4]);
                    int robbery = Int32.Parse(stats[5]);
                    int aggravatedassualt = Int32.Parse(stats[6]);
                    int propertycrime = Int32.Parse(stats[7]);
                    int burglary = Int32.Parse(stats[8]);
                    int theft = Int32.Parse(stats[9]);
                    int motorvehicletheft = Int32.Parse(stats[10]);

                    ReportStat statlist = new ReportStat(year, population, violentcrime, murder, rape, robbery, aggravatedassualt, propertycrime, burglary, theft, motorvehicletheft);
                    ras.Add(statlist);
                }
            }
            return ras;
        }
    }
}
