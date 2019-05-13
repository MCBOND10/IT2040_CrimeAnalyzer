using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeAnalyzer
{
    public class ReportStat
    {
        //declaring all info needed for report
        public int Year;
        public int Population;
        public int ViolentCrime;
        public int Murder;
        public int Rape;
        public int Robbery;
        public int AggravatedAssualt;
        public int PropertyCrime;
        public int Burglary;
        public int Theft;
        public int MotorVehicleTheft;

        //including consructor for report info
        public ReportStat(int year, int population, int violentcrime, int murder, int rape, int robbery, int aggravatedassault, int propertycrime, int burglary, int theft, int motorvehicletheft)
        {
            Year = year;
            Population = population;
            ViolentCrime = violentcrime;
            Murder = murder;
            Rape = rape;
            Robbery = robbery;
            AggravatedAssualt = aggravatedassault;
            PropertyCrime = propertycrime;
            Burglary = burglary;
            Theft = theft;
            MotorVehicleTheft = motorvehicletheft;
        }
    }
}
