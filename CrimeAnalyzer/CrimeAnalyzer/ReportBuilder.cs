using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrimeAnalyzer
{
    public static class ReportBuilder
    {
        public static string CreateReport(List<ReportStat> ras)
        {
            string report = "Crime Analyzer Report\n\n";

            var yearStart = (from statlist in ras select statlist.Year).Min();
            var yearEnd = (from statlist in ras select statlist.Year).Max();
            report += $"\nPeriod: {yearStart}-{yearEnd} ({ras.Count} years)\n";
            
            var years = from statlist in ras where statlist.Murder < 15000 select statlist.Year;
            report += "Years with murders per year < 15,000: ";

            var rob = from statlist in ras where statlist.Robbery > 500000 select statlist;
            report += "Robberies per year > 500,000: ";

            var vc = from statlist in ras where statlist.Year == 2010 select ((double)(statlist.ViolentCrime) / (double)(statlist.Population));
            report += "\n";
            report += "Violent crime per capita rate (2010): ";

            var murdall = (from statlist in ras select statlist.Murder).Average();
            report += "Average murder per year (all years): ";

            var murd1 = (from statlist in ras where statlist.Year >= 1994 && statlist.Year <= 1997 select statlist.Murder).Average();
            report += "Average murder per year (1994-1997): ";

            var murd2 = (from statlist in ras where statlist.Year >= 2010 && statlist.Year <= 2013 select statlist.Murder).Average();
            report += "Average murder per year (2010-2013): ";

            var minT = (from statlist in ras where statlist.Year >= 1999 && statlist.Year <= 2004 select statlist.Theft).Min();
            report += "Minimum thefts per year (1999-2004): ";

            var maxT = (from statlist in ras where statlist.Year >= 1999 && statlist.Year <= 2004 select statlist.Theft).Max();
            report += "Maximum thefts per year (1999-2004): ";

            var mvt = from statlist in ras where statlist.MotorVehicleTheft == ((from statslist in ras select statlist.MotorVehicleTheft).Max()) select statlist.Year;
            report += "Year of highest number of motor vehicle thefts: ";

            return report;

        }
    }
}
