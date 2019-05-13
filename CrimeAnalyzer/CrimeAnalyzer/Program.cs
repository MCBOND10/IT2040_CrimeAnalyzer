using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //if wrong num of files, do this
            if (args.Length != 2)
            {
                Console.WriteLine("");
                Console.WriteLine("CRIME ANALYZER \n\nFormat: CrimeAnalyzer.exe <crime_csv_file_path> <report_file_path>");
                Console.WriteLine("Place holder for professional sounding directions.");
                Console.WriteLine("NOTE: Please input in proper format");
                Console.WriteLine("");
            }
            //if right input, do this
            else
            {
                string dpath = args[0];
                string rpath = args[1];

                List<ReportStat> ras = null;

                ras = ReportGetStat.Load(dpath);

                var report = ReportBuilder.CreateReport(ras);

                System.IO.File.WriteAllText(rpath, report);
            }

        }
    }
}
