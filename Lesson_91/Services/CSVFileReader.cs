using CsvHelper;
using Lesson_91.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Lesson_91.Services
{
    public class CSVFileReader
    {
        public static List<Passengers> GetPassengers()
        {
            List<Passengers> titanicList;

            using (StreamReader reader = new StreamReader("titanic.csv"))
            {
                CsvReader readCsv = new CsvReader(reader, CultureInfo.InvariantCulture);

                titanicList = readCsv.GetRecords<Passengers>().ToList();
            }
            return titanicList;
        }
    }
}





